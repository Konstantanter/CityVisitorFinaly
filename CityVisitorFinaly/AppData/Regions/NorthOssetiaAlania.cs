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
            City Alagir = new City("Алагир", "Unknow.png");
            City Ardon = new City("Ардон", "Unknow.png");
            City Beslan = new City("Беслан", "Beslan.png");
            City Vladikavkaz = new City("Владикавказ", "Vladikavkaz.png");
            City Digora = new City("Дигора", "Unknow.png");
            City Mozdok = new City("Моздок", "Mozdok.png");

            NorthOssetiaAlania.AddCities(Alagir);
            NorthOssetiaAlania.AddCities(Ardon);
            NorthOssetiaAlania.AddCities(Beslan);
            NorthOssetiaAlania.AddCities(Vladikavkaz);
            NorthOssetiaAlania.AddCities(Digora);
            NorthOssetiaAlania.AddCities(Mozdok);

            AddRegToDB(NorthOssetiaAlania);
        }
    }
}
