using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Якутия
        /// </summary>
        public void ChukotkaAO()
        {
            Regions ChukotkaAO = new Regions("Чукотский автономный округ", "chukotka.png")
            {
                IdRegionsMaps = "path359"
            };

            ChukotkaAO.AddCities(new City("Анадырь", "anadyr.png"));
            ChukotkaAO.AddCities(new City("Билибино", "bilibino.png"));
            ChukotkaAO.AddCities(new City("Певек", "pevek.png"));
 

            ChukotkaAO.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(ChukotkaAO);
        }
    }
}
