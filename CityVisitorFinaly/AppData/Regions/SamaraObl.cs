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
            Regions SamaraObl = new Regions("Самарская область", "SamaraObl.png")
            {
                IdRegionsMaps = "path152"
            };
            SamaraObl.AddCities(new City("Жигулёвск", "arkadak.png"));
            SamaraObl.AddCities(new City("Кинель", "atkarsk.png"));
            SamaraObl.AddCities(new City("Нефтегорск", "balakovo.png"));
            SamaraObl.AddCities(new City("Новокуйбышевск", "balashov.png"));
            SamaraObl.AddCities(new City("Октяябрьск", "volsk.png"));
            SamaraObl.AddCities(new City("Отрадный", "ershov.png"));
            SamaraObl.AddCities(new City("Похвистнево", "kalininsk.png"));
            SamaraObl.AddCities(new City("Самара", "krasnoarmeysksaratov.png"));
            SamaraObl.AddCities(new City("Сызрань", "krasnyikyt.png"));
            SamaraObl.AddCities(new City("Тольятти", "marks.png"));
            SamaraObl.AddCities(new City("Чапаевск", "novouzensk.png"));

            SamaraObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(SamaraObl);
        }
    }
}
