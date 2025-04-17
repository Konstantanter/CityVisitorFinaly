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
            Dagestan.AddCities(new City("Буйнакск", "Buinaksk.png"));
            Dagestan.AddCities(new City("Дагестанские Огни", "DagestanskieOgni.png"));
            Dagestan.AddCities(new City("Дербент", "Derbent.png"));
            Dagestan.AddCities(new City("Избербаш", "Izberbash.png"));
            Dagestan.AddCities(new City("Каспийск", "Kaspiysk.png"));
            Dagestan.AddCities(new City("Кизилюрт", "Kiziljurt.png"));
            Dagestan.AddCities(new City("Кизляр", "Kizlyar.png"));
            Dagestan.AddCities(new City("Махачкала", "Makhachkala.png"));
            Dagestan.AddCities(new City("Хасавюрт", "Khasavyurt.png"));
            Dagestan.AddCities(new City("Южно-Сухокумск", "JujnoSukhokumsk.png"));
            Dagestan.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Dagestan);
        }
    }
}
