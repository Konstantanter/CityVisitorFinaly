using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Cевастопль
        /// </summary>
        public void Sevastopl()
        {
            Regions Sevastopl = new Regions("Севастополь", "sevastopolobl.png")
            {
                IdRegionsMaps = "path188"
            };
            City balaklava = new City("Балаклава", "balaklava.png");
            City inkerman = new City("Инкерман", "inkerman.png");
            City sevastopol = new City("Севастополь", "sevastopol.png");

            Sevastopl.AddCities(balaklava);
            Sevastopl.AddCities(inkerman);
            Sevastopl.AddCities(sevastopol);
            AddRegToDB(Sevastopl);
        }
    }
}
