using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация республики Дагестан
        /// </summary>
        public void Dagestan()
        {
            Regions Dagestan = new Regions("Республика Дагестан", "Dagestan.png")
            {
                IdRegionsMaps = "path24"
            };

            City Buinaksk = new City("Буйнакск", "Buinaksk.png");
            City DagestanskieOgni = new City("Дагестанские Огни", "DagestanskieOgni.png");
            City Derbent = new City("Дербент", "Derbent.png");
            City Izberbash = new City("Избербаш", "Izberbash.png");
            City Kaspiysk = new City("Каспийск", "Kaspiysk.png");
            City Kiziljurt = new City("Кизилюрт", "Kiziljurt.png");
            City Kizlyar = new City("Кизляр", "Kizlyar.png");
            City Makhachkala = new City("Махачкала", "Makhachkala.png");
            City Khasavyurt = new City("Хасавюрт", "Khasavyurt.png");
            City JujnoSukhokumsk = new City("Южно-Сухокумск", "JujnoSukhokumsk.png");
            Dagestan.AddCities(Buinaksk);
            Dagestan.AddCities(DagestanskieOgni);
            Dagestan.AddCities(Derbent);
            Dagestan.AddCities(Izberbash);
            Dagestan.AddCities(Kaspiysk);
            Dagestan.AddCities(Kiziljurt);
            Dagestan.AddCities(Kizlyar);
            Dagestan.AddCities(Makhachkala);
            Dagestan.AddCities(Khasavyurt);
            Dagestan.AddCities(JujnoSukhokumsk);

            AddRegToDB(Dagestan);
        }
    }
}
