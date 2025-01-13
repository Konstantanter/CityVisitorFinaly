using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Тюменской области
        /// </summary>
        public void TymenskayaObl()
        {
            Regions TymenskayaObl = new Regions("Тюменская область", "tyumenoblast.png")
            {
                IdRegionsMaps = "path170"
            };
            TymenskayaObl.AddCities(new City("Заводоуковск", "zavodoukovsk.png"));
            TymenskayaObl.AddCities(new City("Ишим", "ishim.png"));
            TymenskayaObl.AddCities(new City("Тобольск", "tobolsk.png"));
            TymenskayaObl.AddCities(new City("Тюмень", "tyumen.png"));
            TymenskayaObl.AddCities(new City("Ялтуровск", "yalutorovsk.png"));
     

            AddRegToDB(TymenskayaObl);
        }
    }
}
