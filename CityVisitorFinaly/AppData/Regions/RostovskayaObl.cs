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
           
            RostovObl.AddCities(new City("Азов", "Azov.png"));
            RostovObl.AddCities(new City("Аксай", "Aksai.png"));
            RostovObl.AddCities(new City("Батайск", "Bataisk.png"));
            RostovObl.AddCities(new City("Белая Калитва", "BelayaKalitva.png"));
            RostovObl.AddCities(new City("Волгодонск", "Volgdonsk.png"));
            RostovObl.AddCities(new City("Гуково", "Gukovo.png"));
            RostovObl.AddCities(new City("Донецк", "Doneck.png"));
            RostovObl.AddCities(new City("Зверево", "Zverevo.png"));
            RostovObl.AddCities(new City("Зерноград", "Zernograd.png"));
            RostovObl.AddCities(new City("Каменск-Шахтинский", "KamenskShakhtinsky.png"));
            RostovObl.AddCities(new City("Константиновск", "Konstantinovsk.png"));
            RostovObl.AddCities(new City("Красный Сулин", "KrasnySulin.png"));
            RostovObl.AddCities(new City("Миллерово", "Millerovo.png"));
            RostovObl.AddCities(new City("Морозовск", "Morozovsk.png"));
            RostovObl.AddCities(new City("Новочеркасск", "Novocherkassk.png"));
            RostovObl.AddCities(new City("Новошахтинск", "Novoshakhtinsk.png"));
            RostovObl.AddCities(new City("Пролетарск", "Proletarsk.png"));
            RostovObl.AddCities(new City("Ростов-на-Дону", "RostovOnDon.png"));
            RostovObl.AddCities(new City("Сальск", "Salsk.png"));
            RostovObl.AddCities(new City("Семикаракорск", "Semikarakorsk.png"));
            RostovObl.AddCities(new City("Таганрог", "Taganrog.png"));
            RostovObl.AddCities(new City("Цимлянск", "Tsimlyansk.png"));
            RostovObl.AddCities(new City("Шахты", "Shahty.png"));
            AddRegToDB(RostovObl);
        }
    }
}
