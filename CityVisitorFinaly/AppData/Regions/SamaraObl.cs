using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Самарской области
        /// </summary>
        public void SamaraObl()
        {
            Regions SamaraObl = new Regions("Самарская область", "samaraobl.png")
            {
                IdRegionsMaps = "path152"
            };
            SamaraObl.AddCities(new City("Жигулёвск", "zhigulyovsk.png"));
            SamaraObl.AddCities(new City("Кинель", "kinel.png"));
            SamaraObl.AddCities(new City("Нефтегорск", "neftegorsk.png"));
            SamaraObl.AddCities(new City("Новокуйбышевск", "novokuybyshevsk.png"));
            SamaraObl.AddCities(new City("Октябрьск", "oktyabrsk.png"));
            SamaraObl.AddCities(new City("Отрадный", "otradny.png"));
            SamaraObl.AddCities(new City("Похвистнево", "pokhvistnevo.png"));
            SamaraObl.AddCities(new City("Самара", "samara.png"));
            SamaraObl.AddCities(new City("Сызрань", "syzran.png"));
            SamaraObl.AddCities(new City("Тольятти", "togliattil.png"));
            SamaraObl.AddCities(new City("Чапаевск", "chapaevsk.png"));

            SamaraObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(SamaraObl);
        }
    }
}
