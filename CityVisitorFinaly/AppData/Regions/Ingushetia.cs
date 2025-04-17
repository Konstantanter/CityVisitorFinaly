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

            Ingushetia.AddCities(new City("Карабулак", "Karabulak.png"));
            Ingushetia.AddCities(new City("Магас", "Magas.png"));
            Ingushetia.AddCities(new City("Малгобек", "Malgobek.png"));
            Ingushetia.AddCities(new City("Назрань", "Nazran.png"));
            Ingushetia.AddCities(new City("Сунжа", "Sunzha.png"));
            Ingushetia.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Ingushetia);
        }
    }
}
