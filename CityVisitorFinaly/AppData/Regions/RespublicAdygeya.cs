using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Адыгея
        /// </summary>
        public void RespublicAdygeya()
        {
            Regions Adygea = new Regions("Республика Адыгея", "adygea.png")
            {
                IdRegionsMaps = "path16"
            };
            City Adygeisk = new City("Адыгейск", "adygeisk.png");
            City Maykop = new City("Майкоп", "maykop.png");

            Adygea.AddCities(Adygeisk);
            Adygea.AddCities(Maykop);
            AddRegToDB(Adygea);
        }
    }
}
