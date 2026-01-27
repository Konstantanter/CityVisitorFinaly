using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Магаданской области
        /// </summary>
        public void MagadanskayaObl()
        {
            Regions MagadanskayaObl = new Regions("Магаданская область", "magadanobl.png")
            {
                IdRegionsMaps = "path126"
            };

            MagadanskayaObl.AddCities(new City("Магадан", "magadan.png"));
            MagadanskayaObl.AddCities(new City("Сусуман", "susuman.png"));



            MagadanskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(MagadanskayaObl);
        }
    }
}
