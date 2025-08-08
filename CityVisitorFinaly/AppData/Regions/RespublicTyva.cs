using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Тыва
        /// </summary>
        public void RespublicTyva()
        {
            Regions RespublicTyva = new Regions("Республика Тыва", "tuva.png")
            {
                IdRegionsMaps = "path50"
            };

            RespublicTyva.AddCities(new City("Ак-Довурак", "akdovurak.png"));
            RespublicTyva.AddCities(new City("Кызыл", "kyzyl.png"));
            RespublicTyva.AddCities(new City("Туран", "turan.png"));
            RespublicTyva.AddCities(new City("Чадан", "chadan.png"));
            RespublicTyva.AddCities(new City("Шагонар", "shagonar.png"));

            RespublicTyva.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicTyva);
        }
    }
}
