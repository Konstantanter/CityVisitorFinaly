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

            VladimirObl.AddCities(new City("Александров", "aleksandrov.png"));
            VladimirObl.AddCities(new City("Владимир", "vladimir.png"));
            VladimirObl.AddCities(new City("Вязники", "vyazniki.png"));
            VladimirObl.AddCities(new City("Гороховец", "gorokhovets.png"));
            VladimirObl.AddCities(new City("Гусь-Хрустальный", "guskhrustalny.png"));
            VladimirObl.AddCities(new City("Камешково", "kamechkovo.png"));
            VladimirObl.AddCities(new City("Карабаново", "karabanovo.png"));
            VladimirObl.AddCities(new City("Киржач", "kirzhach.png"));
            VladimirObl.AddCities(new City("Ковров", "kovrov.png"));
            VladimirObl.AddCities(new City("Кольчугино", "kolch.png"));
            VladimirObl.AddCities(new City("Костерёво", "kosteryovo.png"));
            VladimirObl.AddCities(new City("Курлово", "kurlovo.png"));
            VladimirObl.AddCities(new City("Лакинск", "lakinsk.png"));
            VladimirObl.AddCities(new City("Меленки", "melenki.png"));
            VladimirObl.AddCities(new City("Муром", "murom.png"));
            VladimirObl.AddCities(new City("Петушки", "petushki.png"));
            VladimirObl.AddCities(new City("Покров", "pokrov.png"));
            VladimirObl.AddCities(new City("Радужный", "raduzhny.png"));
            VladimirObl.AddCities(new City("Собинка", "sobinka.png"));
            VladimirObl.AddCities(new City("Струнино", "strunino.png"));
            VladimirObl.AddCities(new City("Судогда", "sudogda.png"));
            VladimirObl.AddCities(new City("Суздаль", "suzdal.png"));
            VladimirObl.AddCities(new City("Юрьев-Польский", "yurievpolskiy.png"));

            AddRegToDB(VladimirObl);
        }
    }
}
