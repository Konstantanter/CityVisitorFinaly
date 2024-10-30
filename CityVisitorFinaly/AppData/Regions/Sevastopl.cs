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

            Sevastopl.AddCities(new City("Балаклава", "balaklava.png"));
            Sevastopl.AddCities(new City("Инкерман", "inkerman.png"));
            Sevastopl.AddCities(new City("Севастополь", "sevastopol.png"));
            AddRegToDB(Sevastopl);
        }
    }
}
