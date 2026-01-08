using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Удмуртия
        /// </summary>
        public void RespublicUdmurtiya()
        {
            Regions RespublicUdmurtiya = new Regions("Республика Удмуртия", "udmurtia.png")
            {
                IdRegionsMaps = "path54"
            };
            RespublicUdmurtiya.AddCities(new City("Воткинск", "votkinsk.png"));
            RespublicUdmurtiya.AddCities(new City("Глазов", "glazov.png"));
            RespublicUdmurtiya.AddCities(new City("Ижевск", "izhevsk.png"));
            RespublicUdmurtiya.AddCities(new City("Камбарка", "kambarka.png"));
            RespublicUdmurtiya.AddCities(new City("Можга", "mozhga.png"));
            RespublicUdmurtiya.AddCities(new City("Сарапул", "sarapul.png"));
            
            RespublicUdmurtiya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicUdmurtiya);
        }
    }
}
