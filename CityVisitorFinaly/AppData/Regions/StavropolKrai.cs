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

            StavropolKrai.AddCities(new City("Благодарный", "Blagodarny.png"));
            StavropolKrai.AddCities(new City("Будённовск", "Budennovsk.png"));
            StavropolKrai.AddCities(new City("Ессентуки", "Essentuki.png"));
            StavropolKrai.AddCities(new City("Георгиевск", "Georgievsk.png"));
            StavropolKrai.AddCities(new City("Железноводск", "Zheleznovodsk.png"));
            StavropolKrai.AddCities(new City("Зеленокумск", "Zelenokumsk.png"));
            StavropolKrai.AddCities(new City("Изобильный", "Izobilny.png"));
            StavropolKrai.AddCities(new City("Ипатово", "Ipatovo.png"));
            StavropolKrai.AddCities(new City("Кисловодск", "Kislovodsk.png"));
            StavropolKrai.AddCities(new City("Лермонтов", "Lermontov.png"));
            StavropolKrai.AddCities(new City("Минеральные Воды", "MineralWaters.png"));
            StavropolKrai.AddCities(new City("Михайловск", "Mihailovsk.png"));
            StavropolKrai.AddCities(new City("Невиномысск", "Nevinomyssk.png"));
            StavropolKrai.AddCities(new City("Нефтекумск", "Neftekumsk.png"));
            StavropolKrai.AddCities(new City("Новоалександровск", "Novoaleksandrovsk.png"));
            StavropolKrai.AddCities(new City("Новопавловск", "Novopavlovsk.png"));
            StavropolKrai.AddCities(new City("Пятигорск", "Pyatigorsk.png"));
            StavropolKrai.AddCities(new City("Светлоград", "Svetlograd.png"));
            StavropolKrai.AddCities(new City("Ставрополь", "Stavropol.png"));

            AddRegToDB(StavropolKrai);
        }
    }
}
