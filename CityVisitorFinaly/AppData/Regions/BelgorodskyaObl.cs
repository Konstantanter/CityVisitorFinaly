using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Белгородской области
        /// </summary>
        public void BelgorodskyaObl()
        {
            Regions BelgorodskyaObl = new Regions("Белгородская область", "belgorodoblast.png")
            {
                IdRegionsMaps = "path92"
            };
            City alekseev = new City("Алексеевка", "alekseev.png");
            City belgorod = new City("Белгород", "belgorod.png");
            City biryuch = new City("Бирюч", "biryuch.png");
            City valuyki = new City("Валуйки", "valuyki.png");
            City grayvoron = new City("Грайворон", "grayvoron.png");
            City gubkin = new City("Губкин", "gubkin.png");
            City korocha = new City("Короча", "korocha.png");
            City novy_oskol = new City("Новый Оскол", "novy_oskol.png");
            City stary_oskol = new City("Старый Оскол", "stary_oskol.png");
            City stroitel = new City("Строитель", "stroitel.png");
            City shebekino = new City("Шебекино", "shebekino.png");

            BelgorodskyaObl.AddCities(alekseev);
            BelgorodskyaObl.AddCities(belgorod);
            BelgorodskyaObl.AddCities(biryuch);
            BelgorodskyaObl.AddCities(valuyki);
            BelgorodskyaObl.AddCities(grayvoron);
            BelgorodskyaObl.AddCities(gubkin);
            BelgorodskyaObl.AddCities(korocha);
            BelgorodskyaObl.AddCities(novy_oskol);
            BelgorodskyaObl.AddCities(stary_oskol);
            BelgorodskyaObl.AddCities(stroitel);
            BelgorodskyaObl.AddCities(shebekino);
            AddRegToDB(BelgorodskyaObl);
        }
    }
}
