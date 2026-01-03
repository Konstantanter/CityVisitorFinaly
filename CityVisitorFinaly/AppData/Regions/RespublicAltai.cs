using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Алтай
        /// </summary>
        public void RespublicAltai()
        {
            Regions Altaikrai = new Regions("Республика Алтай", "altairepublic.png")
            {
                IdRegionsMaps = "path18"
            };
            
            Altaikrai.AddCities(new City("Горно-Алтайск", "gornoaltaisk.png"));
            Altaikrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Altaikrai);
        }
    }
}
