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

            City Karachay = new City("Карачаевск", "Karachay.png");
            City Teberda = new City("Теберда", "Unknow.png");
            City UstDzheguta = new City("Усть-Джегута", "Unknow.png");
            City Cherkessk = new City("Черкесск", "Cherkessk.png");

            KarachayCherkessia.AddCities(Karachay);
            KarachayCherkessia.AddCities(Teberda);
            KarachayCherkessia.AddCities(UstDzheguta);
            KarachayCherkessia.AddCities(Cherkessk);
            AddRegToDB(KarachayCherkessia);
        }
    }
}
