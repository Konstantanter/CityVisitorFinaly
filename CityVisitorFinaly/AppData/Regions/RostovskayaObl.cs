using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ростовской области
        /// </summary>
        public void RostovskayaObl()
        {
            Regions RostovObl = new Regions("Ростовская область", "RostovObl.png")
            {
                IdRegionsMaps = "path148"
            };
            City Azov = new City("Азов", "Azov.png");
            City Aksai = new City("Аксай", "Aksai.png");
            City Bataisk = new City("Батайск", "Bataisk.png");
            City BelayaKalitva = new City("Белая Калитва", "BelayaKalitva.png");
            City Volgdonsk = new City("Волгодонск", "Volgdonsk.png");
            City Gukovo = new City("Гуково", "Gukovo.png");
            City Doneck = new City("Донецк", "Doneck.png");
            City Zverevo = new City("Зверево", "Zverevo.png");
            City Zernograd = new City("Зерноград", "Zernograd.png");
            City KamenskShakhtinsky = new City("Каменск-Шахтинский", "KamenskShakhtinsky.png");
            City Konstantinovsk = new City("Константиновск", "Konstantinovsk.png");
            City KrasnySulin = new City("Красный Сулин", "KrasnySulin.png");
            City Millerovo = new City("Миллерово", "Millerovo.png");
            City Morozovsk = new City("Морозовск", "Morozovsk.png");
            City Novocherkassk = new City("Новочеркасск", "Novocherkassk.png");
            City Novoshakhtinsk = new City("Новошахтинск", "Novoshakhtinsk.png");
            City Proletarsk = new City("Пролетарск", "Proletarsk.png");
            City RostovOnDon = new City("Ростов-на-Дону", "RostovOnDon.png");
            City Salsk = new City("Сальск", "Salsk.png");
            City Semikarakorsk = new City("Семикаракорск", "Semikarakorsk.png");
            City Taganrog = new City("Таганрог", "Taganrog.png");
            City Tsimlyansk = new City("Цимлянск", "Tsimlyansk.png");
            City Shahty = new City("Шахты", "Shahty.png");
            RostovObl.AddCities(Azov);
            RostovObl.AddCities(Aksai);
            RostovObl.AddCities(Bataisk);
            RostovObl.AddCities(BelayaKalitva);
            RostovObl.AddCities(Volgdonsk);
            RostovObl.AddCities(Gukovo);
            RostovObl.AddCities(Doneck);
            RostovObl.AddCities(Zverevo);
            RostovObl.AddCities(Zernograd);
            RostovObl.AddCities(KamenskShakhtinsky);
            RostovObl.AddCities(Konstantinovsk);
            RostovObl.AddCities(KrasnySulin);
            RostovObl.AddCities(Millerovo);
            RostovObl.AddCities(Morozovsk);
            RostovObl.AddCities(Novocherkassk);
            RostovObl.AddCities(Novoshakhtinsk);
            RostovObl.AddCities(Proletarsk);
            RostovObl.AddCities(RostovOnDon);
            RostovObl.AddCities(Salsk);
            RostovObl.AddCities(Semikarakorsk);
            RostovObl.AddCities(Taganrog);
            RostovObl.AddCities(Tsimlyansk);
            RostovObl.AddCities(Shahty);
            AddRegToDB(RostovObl);
        }
    }
}
