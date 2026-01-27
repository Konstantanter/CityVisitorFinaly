using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Еврейской АО
        /// </summary>
        public void EvreiskayaAO()
        {
            Regions EvreiskayaAO = new Regions("Еврейская АО", "jewishautonomousobl.png")
            {
                IdRegionsMaps = "path353"
            };

            EvreiskayaAO.AddCities(new City("Биробиджан", "birobidzhan.png"));
            EvreiskayaAO.AddCities(new City("Облучье", "obluche.png"));

            EvreiskayaAO.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(EvreiskayaAO);
        }
    }
}
