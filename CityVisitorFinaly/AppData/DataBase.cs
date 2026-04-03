using SQLite;

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
    }
}