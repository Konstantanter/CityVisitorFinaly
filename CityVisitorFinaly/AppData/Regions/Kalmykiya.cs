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
                IdRegionsMaps = "path148"
            };

            City Gorodovikovsk = new City("Городовиковск", "Gorodovikovsk.png");
            City Lagan = new City("Лагань", "Lagan.png");
            City Elista = new City("Элиста", "Elista.png");
            Kalmykiya.AddCities(Gorodovikovsk);
            Kalmykiya.AddCities(Lagan);
            Kalmykiya.AddCities(Elista);
            AddRegToDB(Kalmykiya);
        }
    }
}
