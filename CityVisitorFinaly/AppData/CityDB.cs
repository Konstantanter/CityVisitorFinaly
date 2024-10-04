using SQLite;

namespace CityVisitorFinaly.AppData
{
    public class CityDB
    {
        /// <summary>
        // ИД города
        /// </summary>
        [PrimaryKey]
        public int Id { get; set; }
        /// <summary>
        /// Наличие магнита
        /// </summary>
        public bool Magned { get; set; }
        /// <summary>
        /// ИД региона
        /// </summary>
        public int Regionid { get; set; }
        /// <summary>
        /// ИД на карте
        /// </summary>
        public string IdRegionsMaps { get; set; }
        /// <summary>
        /// Дата посещения
        /// </summary>
        public string DataVisited { get; set; }
        /// <summary>
        /// Имя города
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// Статус города
        /// </summary>
        public State StateCity { get; set; }
        /// <summary>
        /// Обновление города в базе данных
        /// </summary>
        public void SaveCity()
        {
            App.Db.UpdateCity(this);
        }
        /// <summary>
        /// Вставка города в базу данных
        /// </summary>
        public void InsertCity()
        {
            App.Db.InsertCity(this);
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CityDB() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="city">Город из представления</param>
        /// <param name="regionId">ИД региона</param>
        public CityDB(City city, int regionId)
        {
            Id = city.IdCity;
            Regionid = regionId;
            Name = city.Name;
            ImagePath = city.ImagePath;
            StateCity = city.State;
            Magned = city.Magned;
            IdRegionsMaps = city.IdRegionsMaps;
            DataVisited = city.DataVisited;
        }
    }
}
