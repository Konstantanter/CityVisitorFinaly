using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {

        /// <summary>
        /// Инициализация города Москва
        /// </summary>
        public void Moskov()
        {
            Regions Moscov = new Regions("город Москва", "moscovreg.png")
            {
                IdRegionsMaps = "path184"
            };
            City moscov = new City("Москва", "moscov.png");
            City zelenograd = new City("Зеленоград", "zelenograd.png");
            City moskovsky = new City("Московский", "moskovsky.png");
            City troick = new City("Троицк", "troick.png");
            City scherbinka = new City("Щербинка", "scherbinka.png");

            Moscov.AddCities(moscov);
            Moscov.AddCities(zelenograd);
            Moscov.AddCities(moskovsky);
            Moscov.AddCities(troick);
            Moscov.AddCities(scherbinka);
            AddRegToDB(Moscov);

        }
    }
}
