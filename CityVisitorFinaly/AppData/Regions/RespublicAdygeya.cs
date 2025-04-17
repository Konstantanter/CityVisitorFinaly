using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Адыгея
        /// </summary>
        public void RespublicAdygeya()
        {
            Regions Adygea = new Regions("Республика Адыгея", "adygea.png")
            {
                IdRegionsMaps = "path16"
            };

            Adygea.AddCities(new City("Адыгейск", "adygeisk.png"));
            Adygea.AddCities(new City("Майкоп", "maykop.png"));
            Adygea.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Adygea);
        }
    }
}
