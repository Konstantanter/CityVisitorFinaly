using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Чувашия
        /// </summary>
        public void RespublicChuvashiya()
        {
            Regions RespublicChuvashiya = new Regions("Республика Чувашия", "chuvashia.png")
            {
                IdRegionsMaps = "path62"
            };
            RespublicChuvashiya.AddCities(new City("Алатырь", "alatyr.png"));
            RespublicChuvashiya.AddCities(new City("Канаш", "kanash.png"));
            RespublicChuvashiya.AddCities(new City("Козловка", "kozlovka.png"));
            RespublicChuvashiya.AddCities(new City("Мариинский Посад", "mariinskyposad.png"));
            RespublicChuvashiya.AddCities(new City("Новочебоксарск", "novocheboksarsk.png"));
            RespublicChuvashiya.AddCities(new City("Цивильск", "zcivilsk.png"));
            RespublicChuvashiya.AddCities(new City("Чебоксарск", "cheboksary.png"));
            RespublicChuvashiya.AddCities(new City("Шумерля", "shumerlya.png"));
            RespublicChuvashiya.AddCities(new City("Ядрин", "yadrin.png"));

            RespublicChuvashiya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicChuvashiya);
        }
    }
}
