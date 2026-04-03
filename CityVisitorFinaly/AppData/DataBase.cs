using CityVisitorFinaly.AppData.DataRegions;
using Newtonsoft.Json;
using SQLite;
using System.Diagnostics;
using System.Reflection;

namespace CityVisitorFinaly.AppData
{
    public class DataBase
    {
        private readonly SQLiteAsyncConnection db;

        public DataBase(string connection)
        {
            db = new SQLiteAsyncConnection(connection);
            db.CreateTableAsync<CityDB>().Wait();
            db.CreateTableAsync<RegionsDB>().Wait();
        }

        // ✅ ДОБАВИТЬ: Доступ к соединению для транзакций
        public SQLiteAsyncConnection Connection => db;

        // ✅ ДОБАВИТЬ: Метод подсчёта регионов
        public Task<int> GetRegionsCountAsync()
            => db.Table<RegionsDB>().CountAsync();

        public Task<List<RegionsDB>> GetRegions()
            => db.Table<RegionsDB>().ToListAsync();

        public Task<List<CityDB>> GetCitiesFromRegion(int idRegion)
            => db.Table<CityDB>().Where(a => a.Regionid == idRegion).ToListAsync();

        public Task<int> InsertRegion(RegionsDB reg)
            => db.InsertAsync(reg);

        public Task<int> UpdateRegion(RegionsDB reg)
            => db.UpdateAsync(reg);

        public Task<CityDB> GetCity(int IdCity)
            => db.Table<CityDB>().Where(a => a.Id == IdCity).FirstOrDefaultAsync();

        public Task<int> InsertCity(CityDB city)
            => db.InsertAsync(city);

        public Task<int> UpdateCity(CityDB city)
            => db.UpdateAsync(city);
        public Task<List<CityDB>> GetAllCitiesAsync()
        {
            return db.Table<CityDB>().ToListAsync();
        }
        public Task<int> DeleteCity(CityDB city)
            => db.DeleteAsync(city);
    
     public async Task SeedDatabase()
        {
            if (await App.Db.GetRegionsCountAsync() > 0)
                return;

            Assembly assembly = GetType().GetTypeInfo().Assembly;
            // using Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Raw.regions.json");
            using var stream = await FileSystem.OpenAppPackageFileAsync("regions.json");
            if (stream == null) return;

            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();
            var regionsDto = JsonConvert.DeserializeObject<List<RegionDto>>(json);

            var regionsToInsert = new List<RegionsDB>();
            var citiesToInsert = new List<CityDB>();
            var nameToRegionMap = new Dictionary<string, RegionsDB>();

            foreach (var regDto in regionsDto)
            {
                var region = new RegionsDB
                {
                    Name = regDto.Name,
                    PathImage = regDto.ImagePath,
                    IdRegionsMaps = regDto.MapId
                };

                nameToRegionMap[regDto.Name] = region; // Сохраняем в словарь по имени
                regionsToInsert.Add(region);

                foreach (var cityDto in regDto.Cities)
                {
                    citiesToInsert.Add(new CityDB
                    {
                        Name = cityDto.Name,
                        ImagePath = cityDto.Image,
                        StateCity = State.NotVisited,
                        TempRegionName = regDto.Name
                    });
                }
            }

            // 🔥 Выполняем всё в одной транзакции
            await App.Db.Connection.RunInTransactionAsync(conn =>
            {
                // 1. Вставляем регионы — теперь у них есть реальные Id
                conn.InsertAll(regionsToInsert);

                // 2. Проставляем Regionid у городов, используя словарь и временное имя
                foreach (var city in citiesToInsert)
                {
                    if (!string.IsNullOrEmpty(city.TempRegionName) &&
                        nameToRegionMap.TryGetValue(city.TempRegionName, out var region))
                    {
                        city.Regionid = region.Id; // ✅ Теперь Id корректный
                    }
                }

                // 3. Вставляем города с правильными внешними ключами
                conn.InsertAll(citiesToInsert);
            });
        }
    }
}