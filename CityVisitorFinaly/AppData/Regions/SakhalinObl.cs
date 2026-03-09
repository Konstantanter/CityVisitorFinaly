using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Сахалинской области
        /// </summary>
        public void SakhalinObl()
        {
            Regions SakhalinObl = new Regions("Сахалинская область", "sakhalinobl.png")
            {
                IdRegionsMaps = "path156"
            };

            SakhalinObl.AddCities(new City("Александровск-Сахалинский", "aleksandrovsksahalinsk.png"));
            SakhalinObl.AddCities(new City("Анива", "aniva.png"));
            SakhalinObl.AddCities(new City("Долинск", "dolinsky.png"));
            SakhalinObl.AddCities(new City("Корсаков", "korsakov.png"));
            SakhalinObl.AddCities(new City("Курильск", "kurilsk.png"));
            SakhalinObl.AddCities(new City("Макаров", "makarov.png"));
            SakhalinObl.AddCities(new City("Невельск", "nevelsk.png"));
            SakhalinObl.AddCities(new City("Оха", "oha.png"));
            SakhalinObl.AddCities(new City("Поронайск", "poronaysk.png"));
            SakhalinObl.AddCities(new City("Севео-Курильск", "severokurilsk.png"));
            SakhalinObl.AddCities(new City("Томари", "tomari.png"));
            SakhalinObl.AddCities(new City("Углегорск", "uglegorski.png"));
            SakhalinObl.AddCities(new City("Холмск", "kholmsk.png"));
            SakhalinObl.AddCities(new City("Южно-Сахалинск", "yuzhnosakhalinsk.png"));
            
            AddRegToDB(SakhalinObl);
        }
    }
}
