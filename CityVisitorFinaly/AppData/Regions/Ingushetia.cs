using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация республики Ингушетия
        /// </summary>
        public void Ingushetia()
        {
            Regions Ingushetia = new Regions("Республика Ингушетия", "Ingushetia.png")
            {
                IdRegionsMaps = "path26"
            };

            City Karabulak = new City("Карабулак", "Karabulak.png");
            City Magas = new City("Магас", "Magas.png");
            City Malgobek = new City("Малгобек", "Malgobek.png");
            City Nazran = new City("Назрань", "Nazran.png");
            City Sunzha = new City("Сунжа", "Sunzha.png");
            Ingushetia.AddCities(Karabulak);
            Ingushetia.AddCities(Magas);
            Ingushetia.AddCities(Malgobek);
            Ingushetia.AddCities(Nazran);
            Ingushetia.AddCities(Sunzha);
            AddRegToDB(Ingushetia);
        }
    }
}
