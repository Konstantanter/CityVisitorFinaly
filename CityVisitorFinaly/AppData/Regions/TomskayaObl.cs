using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Томской области
        /// </summary>
        public void TomskayaObl()
        {
            Regions TomskayaObl = new Regions("Томская область", "tomskoblast.png")
            {
                IdRegionsMaps = "path166"
            };

            TomskayaObl.AddCities(new City("Асино", "asino.png"));
            TomskayaObl.AddCities(new City("Кедровый", "kedrovy.png"));
            TomskayaObl.AddCities(new City("Колпашево", "kolpashevo.png"));
            TomskayaObl.AddCities(new City("Северск", "seversk.png"));
            TomskayaObl.AddCities(new City("Стрежевой", "strezhevoi.png"));
            TomskayaObl.AddCities(new City("Томск", "tomsk.png"));

            TomskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(TomskayaObl);
        }
    }
}
