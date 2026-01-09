using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Якутия
        /// </summary>
        public void RespublicYakutiya()
        {
            Regions RespublicYakutiya = new Regions("Республика Саха (Якутия)", "sakha_yakutia.png")
            {
                IdRegionsMaps = "path44"
            };

            RespublicYakutiya.AddCities(new City("Алдан", "aldan.png"));
            RespublicYakutiya.AddCities(new City("Верхоянск", "verkhoyansk.png"));
            RespublicYakutiya.AddCities(new City("Вилюйск", "viluysk.png"));
            RespublicYakutiya.AddCities(new City("Ленск", "lensk.png"));
            RespublicYakutiya.AddCities(new City("Мирный", "mirny_yakutiya.png"));
            RespublicYakutiya.AddCities(new City("Нерюнгри", "neryungri.png"));
            RespublicYakutiya.AddCities(new City("Нюрба", "nyurba.png"));
            RespublicYakutiya.AddCities(new City("Олёкминск", "olekminsk.png"));
            RespublicYakutiya.AddCities(new City("Покровск", "pokrovsk.png"));
            RespublicYakutiya.AddCities(new City("Среднеколымск", "srednekolymsk.png"));
            RespublicYakutiya.AddCities(new City("Томмот", "tommot.png"));
            RespublicYakutiya.AddCities(new City("Удачный", "udachny.png"));
            RespublicYakutiya.AddCities(new City("Якутск", "yakutsk.png"));
            
            RespublicYakutiya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicYakutiya);
        }
    }
}
