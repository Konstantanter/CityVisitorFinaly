using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ульяновской области
        /// </summary>
        public void UlyanovskayaObl()
        {
            Regions UlyanovskayaObl = new Regions("Ульяновская область", "ulyanovskreg.png")
            {
                IdRegionsMaps = "path172"
            };

            UlyanovskayaObl.AddCities(new City("Барыш", "barysh.png"));
            UlyanovskayaObl.AddCities(new City("Димитровград", "dimitrovgrad.png"));
            UlyanovskayaObl.AddCities(new City("Инза", "inza.png"));
            UlyanovskayaObl.AddCities(new City("Новоульяновск", "novoulyanovsk.png"));
            UlyanovskayaObl.AddCities(new City("Сенгилей", "sengiley.png"));
            UlyanovskayaObl.AddCities(new City("Ульяновск", "ulyanovsk.png"));
 
            UlyanovskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(UlyanovskayaObl);
        }
    }
}
