using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Хакасия
        /// </summary>
        public void RespublicKhakasiya()
        {
            Regions RespublicKhakasiya = new Regions("Республика Хакасия", "khakassia.png")
            {
                IdRegionsMaps = "path56"
            };

            RespublicKhakasiya.AddCities(new City("Абаза", "abakan.png"));
            RespublicKhakasiya.AddCities(new City("Абакан", "abaza.png"));
            RespublicKhakasiya.AddCities(new City("Саяногорск", "sayanogorsk.png"));
            RespublicKhakasiya.AddCities(new City("Сорск", "sorsk.png"));
            RespublicKhakasiya.AddCities(new City("Черногорск", "chernogorsk.png"));

            RespublicKhakasiya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicKhakasiya);
        }
    }
}
