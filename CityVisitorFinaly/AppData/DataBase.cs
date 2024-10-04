using SQLite;

namespace CityVisitorFinaly.AppData
{
    /// <summary>
    /// База данных
    /// </summary>
    public class DataBase
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        private readonly SQLiteAsyncConnection db;
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="connection">Строка подключения</param>
        public DataBase(string connection)
        {
            db = new SQLiteAsyncConnection(connection);
            db.CreateTableAsync<CityDB>().Wait();
            db.CreateTableAsync<RegionsDB>().Wait();
        }
        /// <summary>
        /// Получение регионов из базы данных
        /// </summary>
        public Task<List<RegionsDB>> GetRegions()
        {
            return db.Table<RegionsDB>().ToListAsync();
        }
        /// <summary>
        /// Получение городов региона
        /// </summary>
        /// <param name="idRegion">ИД региона</param>
        public Task<List<CityDB>> GetCitiesFromRegion(int idRegion)
        {
            return db.Table<CityDB>().Where(a => a.Regionid == idRegion).ToListAsync();
        }
        /// <summary>
        /// Вставка региона в базу данных
        /// </summary>
        /// <param name="reg">Регион</param>
        public Task<int> InsertRegion(RegionsDB reg)
        {
            return db.InsertAsync(reg);
        }
        /// <summary>
        /// Обновление региона
        /// </summary>
        public Task<int> UpdateRegion(RegionsDB reg)
        {
            return db.UpdateAsync(reg);
        }
        /// <summary>
        /// Получение города
        /// </summary>
        public Task<CityDB> GetCity(int IdCity)
        {
            return db.Table<CityDB>().Where(a => a.Id == IdCity).FirstOrDefaultAsync();
        }
        /// <summary>
        /// Вставка города в базу данных
        /// </summary>
        public Task<int> InsertCity(CityDB city)
        {
            return db.InsertAsync(city);
        }
        /// <summary>
        /// Обновление города
        /// </summary>
        public Task<int> UpdateCity(CityDB city)
        {
            return db.UpdateAsync(city);
        }
        /// <summary>
        /// Удаление города
        /// </summary>
        public Task<int> DeleteCity(CityDB city)
        {
            return db.DeleteAsync(city);
        }
    }
}
