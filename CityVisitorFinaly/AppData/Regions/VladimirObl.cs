using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Владимировской области
        /// </summary>
        public void VladimirObl()
        {
            Regions VladimirObl = new Regions("Владимировская область", "vladimirioblast.png")
            {
                IdRegionsMaps = "path96"
            };
            City aleksandrov = new City("Александров", "aleksandrov.png");
            City vladimir = new City("Владимир", "vladimir.png");
            City vyazniki = new City("Вязники", "vyazniki.png");
            City gorokhovets = new City("Гороховец", "gorokhovets.png");
            City guskhrustalny = new City("Гусь-Хрустальный", "guskhrustalny.png");
            City kamechkovo = new City("Камешково", "kamechkovo.png");
            City karabanovo = new City("Карабаново", "karabanovo.png");
            City kirzhach = new City("Киржач", "kirzhach.png");
            City kovrov = new City("Ковров", "kovrov.png");
            City kolch = new City("Кольчугино", "kolch.png");
            City kosteryovo = new City("Костерёво", "kosteryovo.png");
            City kurlovo = new City("Курлово", "kurlovo.png");
            City lakinsk = new City("Лакинск", "lakinsk.png");
            City melenki = new City("Меленки", "melenki.png");
            City murom = new City("Муром", "murom.png");
            City petushki = new City("Петушки", "petushki.png");
            City pokrov = new City("Покров", "pokrov.png");
            City raduzhny = new City("Радужный", "raduzhny.png");
            City sobinka = new City("Собинка", "sobinka.png");
            City strunino = new City("Струнино", "strunino.png");
            City sudogda = new City("Судогда", "sudogda.png");
            City suzdal = new City("Суздаль", "suzdal.png");
            City yurievpolskiy = new City("Юрьев-Польский", "yurievpolskiy.png");

            VladimirObl.AddCities(aleksandrov);
            VladimirObl.AddCities(vladimir);
            VladimirObl.AddCities(vyazniki);
            VladimirObl.AddCities(gorokhovets);
            VladimirObl.AddCities(guskhrustalny);
            VladimirObl.AddCities(kamechkovo);
            VladimirObl.AddCities(karabanovo);
            VladimirObl.AddCities(kirzhach);
            VladimirObl.AddCities(kovrov);
            VladimirObl.AddCities(kolch);
            VladimirObl.AddCities(kosteryovo);
            VladimirObl.AddCities(kurlovo);
            VladimirObl.AddCities(lakinsk);
            VladimirObl.AddCities(melenki);
            VladimirObl.AddCities(murom);
            VladimirObl.AddCities(petushki);
            VladimirObl.AddCities(pokrov);
            VladimirObl.AddCities(raduzhny);
            VladimirObl.AddCities(sobinka);
            VladimirObl.AddCities(strunino);
            VladimirObl.AddCities(sudogda);
            VladimirObl.AddCities(suzdal);
            VladimirObl.AddCities(yurievpolskiy);
            AddRegToDB(VladimirObl);
        }
    }
}
