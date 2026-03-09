using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Мордовия
        /// </summary>
        public void RespublicMordovia()
        {
            Regions RespublicMordovia = new Regions("Республика Мордовия", "mordovia.png")
            {
                IdRegionsMaps = "path42"
            };

            RespublicMordovia.AddCities(new City("Ардатов", "ardatov.png"));
            RespublicMordovia.AddCities(new City("Инсар", "insar.png"));
            RespublicMordovia.AddCities(new City("Ковылкино", "kovylkino.png"));
            RespublicMordovia.AddCities(new City("Краснослободск", "krasnoslobodsk_mord.png"));
            RespublicMordovia.AddCities(new City("Рузаевка", "ruzaevka.png"));
            RespublicMordovia.AddCities(new City("Саранск", "saransk.png"));
            RespublicMordovia.AddCities(new City("Темников", "temnikov.png"));

           
            AddRegToDB(RespublicMordovia);
        }
    }
}
