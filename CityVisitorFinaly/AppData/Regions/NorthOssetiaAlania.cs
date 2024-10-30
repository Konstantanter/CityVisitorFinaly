using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация Республики Северная Осетия (Алания)
        /// </summary>
        public void NorthOssetiaAlania()
        {
            Regions NorthOssetiaAlania = new Regions("Республика Северная Осетия - Алания", "NorthOssetiaAlania.png")
            {
                IdRegionsMaps = "path46"
            };

            NorthOssetiaAlania.AddCities(new City("Алагир", "Unknow.png"));
            NorthOssetiaAlania.AddCities(new City("Ардон", "Unknow.png"));
            NorthOssetiaAlania.AddCities(new City("Беслан", "Beslan.png"));
            NorthOssetiaAlania.AddCities(new City("Владикавказ", "Vladikavkaz.png"));
            NorthOssetiaAlania.AddCities(new City("Дигора", "Unknow.png"));
            NorthOssetiaAlania.AddCities(new City("Моздок", "Mozdok.png"));

            AddRegToDB(NorthOssetiaAlania);
        }
    }
}
