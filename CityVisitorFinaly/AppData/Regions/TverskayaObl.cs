using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Тверской области
        /// </summary>
        public void TverskayaObl()
        {
            Regions TverskayaObl = new Regions("Тверская область", "tveroblast.png")
            {
                IdRegionsMaps = "path164"
            };
            TverskayaObl.AddCities(new City("Андреаполь", "andreapol.png"));
            TverskayaObl.AddCities(new City("Бежецк", "bezhetsk.png"));
            TverskayaObl.AddCities(new City("Белый", "bely.png"));
            TverskayaObl.AddCities(new City("Бологое", "bologoe.png"));
            TverskayaObl.AddCities(new City("Весьегонск", "vesegonsk.png"));
            TverskayaObl.AddCities(new City("Вышний Волочёк", "vyshnyvolochek.png"));
            TverskayaObl.AddCities(new City("Западная Двина", "zapadnayadvina.png"));
            TverskayaObl.AddCities(new City("Зубцов", "zubtsov.png"));
            TverskayaObl.AddCities(new City("Калязин", "kalyazin.png"));
            TverskayaObl.AddCities(new City("Кашин", "kashin.png"));
            TverskayaObl.AddCities(new City("Кимры", "kimry.png"));
            TverskayaObl.AddCities(new City("Конаково", "konakovo.png"));
            TverskayaObl.AddCities(new City("Красный Холм", "krasnykholm.png"));
            TverskayaObl.AddCities(new City("Кувшиново", "kuvshinovo.png"));
            TverskayaObl.AddCities(new City("Лихославль", "likhoslavl.png"));
            TverskayaObl.AddCities(new City("Нелидово", "nelidovo.png"));
            TverskayaObl.AddCities(new City("Осташков", "ostashkov.png"));
            TverskayaObl.AddCities(new City("Ржев", "rzhev.png"));
            TverskayaObl.AddCities(new City("Старица", "staritsa.png"));
            TverskayaObl.AddCities(new City("Тверь", "tver.png"));
            TverskayaObl.AddCities(new City("Торжок", "torzhok.png"));
            TverskayaObl.AddCities(new City("Торопец", "toropets.png"));
            TverskayaObl.AddCities(new City("Удомля", "udomlya.png"));

            AddRegToDB(TverskayaObl);
        }
    }
}
