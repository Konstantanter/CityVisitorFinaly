using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ставропольского края
        /// </summary>
        public void StavropolKrai()
        {
            Regions StavropolKrai = new Regions("Ставропольский край", "StavropolKrai.png")
            {
                IdRegionsMaps = "path80"
            };
            City Blagodarny = new City("Благодарный", "Blagodarny.png");
            City Budennovsk = new City("Будённовск", "Budennovsk.png");
            City Essentuki = new City("Ессентуки", "Essentuki.png");
            City Georgievsk = new City("Георгиевск", "Georgievsk.png");
            City Zheleznovodsk = new City("Железноводск", "Zheleznovodsk.png");
            City Zelenokumsk = new City("Зеленокумск", "Zelenokumsk.png");
            City Izobilny = new City("Изобильный", "Izobilny.png");
            City Ipatovo = new City("Ипатово", "Ipatovo.png");
            City Kislovodsk = new City("Кисловодск", "Kislovodsk.png");
            City Lermontov = new City("Лермонтов", "Lermontov.png");
            City MineralWaters = new City("Минеральные Воды", "MineralWaters.png");
            City Mihailovsk = new City("Михайловск", "Mihailovsk.png");
            City Nevinomyssk = new City("Невиномысск", "Nevinomyssk.png");
            City Neftekumsk = new City("Нефтекумск", "Neftekumsk.png");
            City Novoaleksandrovsk = new City("Новоалександровск", "Novoaleksandrovsk.png");
            City Novopavlovsk = new City("Новопавловск", "Novopavlovsk.png");
            City Pyatigorsk = new City("Пятигорск", "Pyatigorsk.png");
            City Svetlograd = new City("Светлоград", "Svetlograd.png");
            City Stavropol = new City("Ставрополь", "Stavropol.png");

            StavropolKrai.AddCities(Blagodarny);
            StavropolKrai.AddCities(Budennovsk);
            StavropolKrai.AddCities(Essentuki);
            StavropolKrai.AddCities(Georgievsk);
            StavropolKrai.AddCities(Zheleznovodsk);
            StavropolKrai.AddCities(Zelenokumsk);
            StavropolKrai.AddCities(Izobilny);
            StavropolKrai.AddCities(Ipatovo);
            StavropolKrai.AddCities(Kislovodsk);
            StavropolKrai.AddCities(Lermontov);
            StavropolKrai.AddCities(MineralWaters);
            StavropolKrai.AddCities(Mihailovsk);
            StavropolKrai.AddCities(Nevinomyssk);
            StavropolKrai.AddCities(Neftekumsk);
            StavropolKrai.AddCities(Novoaleksandrovsk);
            StavropolKrai.AddCities(Novopavlovsk);
            StavropolKrai.AddCities(Pyatigorsk);
            StavropolKrai.AddCities(Svetlograd);
            StavropolKrai.AddCities(Stavropol);

            AddRegToDB(StavropolKrai);
        }
    }
}
