using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация Карачаево Черкесской Республики
        /// </summary>
        public void KarachayCherkessia()
        {
            Regions KarachayCherkessia = new Regions("Карачаево-Черкесская республика", "KarachayCherkessia.png")
            {
                IdRegionsMaps = "path32"
            };

            KarachayCherkessia.AddCities(new City("Карачаевск", "Karachay.png"));
            KarachayCherkessia.AddCities(new City("Теберда", "Unknow.png"));
            KarachayCherkessia.AddCities(new City("Усть-Джегута", "Unknow.png"));
            KarachayCherkessia.AddCities(new City("Черкесск", "Cherkessk.png"));

            AddRegToDB(KarachayCherkessia);
        }
    }
}
