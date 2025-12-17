using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Карелия
        /// </summary>
        public void RespulicKareliya()
        {
            Regions RespulicKareliya = new Regions("Псковская область", "republic_of_karelia.png")
            {
                IdRegionsMaps = "path34"
            };
            RespulicKareliya.AddCities(new City("Беломорск", "belomorsk.png"));
            RespulicKareliya.AddCities(new City("Кемь", "kem.png"));
            RespulicKareliya.AddCities(new City("Кондопога", "kondopoga.png"));
            RespulicKareliya.AddCities(new City("Костомукша", "kostomuksha.png"));
            RespulicKareliya.AddCities(new City("Лахдепонхья", "lahdenpohiya.png"));
            RespulicKareliya.AddCities(new City("Медвежьегорск", "medvezhegorsk.png"));
            RespulicKareliya.AddCities(new City("Олонец", "olonets.png"));
            RespulicKareliya.AddCities(new City("Петрозаводск", "petrozavodsk.png"));
            RespulicKareliya.AddCities(new City("Питкяранта", "pitkyaranta.png"));
            RespulicKareliya.AddCities(new City("Пудож", "pudozh.png"));
            RespulicKareliya.AddCities(new City("Сегежа", "segezha.png"));
            RespulicKareliya.AddCities(new City("Сортавала", "sortavala.png"));
            RespulicKareliya.AddCities(new City("Суоярви", "suoyarv.png"));
           
            RespulicKareliya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespulicKareliya);
        }
    }
}
