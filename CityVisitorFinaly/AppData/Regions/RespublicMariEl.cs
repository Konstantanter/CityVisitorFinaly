using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Марий-Эл
        /// </summary>
        public void RespublicMariEl()
        {
            Regions RespublicMariEl = new Regions("Республика Марий-Эл", "mariel.png")
            {
                IdRegionsMaps = "path40"
            };
            RespublicMariEl.AddCities(new City("Волжск", "volzhsk.png"));
            RespublicMariEl.AddCities(new City("Звенигово", "zvenigovo.png"));
            RespublicMariEl.AddCities(new City("Йошкар-Ола", "yoshkarola.png"));
            RespublicMariEl.AddCities(new City("Козьмодемьянск", "kozmodemiansk.png"));
            
            RespublicMariEl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicMariEl);
        }
    }
}
