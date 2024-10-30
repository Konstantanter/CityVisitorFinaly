using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация республики Калмыкии
        /// </summary>
        public void Kalmykiya()
        {
            Regions Kalmykiya = new Regions("Республика Калмыкия", "Kalmykiya.png")
            {
                IdRegionsMaps = "path30"
            };

            Kalmykiya.AddCities(new City("Городовиковск", "Gorodovikovsk.png"));
            Kalmykiya.AddCities(new City("Лагань", "Lagan.png"));
            Kalmykiya.AddCities(new City("Элиста", "Elista.png"));

            AddRegToDB(Kalmykiya);
        }
    }
}
