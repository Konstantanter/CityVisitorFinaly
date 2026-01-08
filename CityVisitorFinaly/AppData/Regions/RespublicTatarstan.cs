using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Татарстан
        /// </summary>
        public void RespublicTatarstan()
        {
            Regions RespublicTatarstan = new Regions("Республика Татарстан", "tatarstan.png")
            {
                IdRegionsMaps = "path48"
            };
            RespublicTatarstan.AddCities(new City("Агрыз", "agryz.png"));
            RespublicTatarstan.AddCities(new City("Азнакаево", "aznakevo.png"));
            RespublicTatarstan.AddCities(new City("Альметьевск", "almetievsk.png"));
            RespublicTatarstan.AddCities(new City("Арск", "arsk.png"));
            RespublicTatarstan.AddCities(new City("Бавлы", "bavly.png"));
            RespublicTatarstan.AddCities(new City("Болгар", "bolgar.png"));
            RespublicTatarstan.AddCities(new City("Бугульма", "bugulma.png"));
            RespublicTatarstan.AddCities(new City("Буинск", "samara.png"));
            RespublicTatarstan.AddCities(new City("Елабуга", "syzran.png"));
            RespublicTatarstan.AddCities(new City("Заинск", "zainsk.png"));
            RespublicTatarstan.AddCities(new City("Зеленодольск", "zelenodolsk.png"));
            RespublicTatarstan.AddCities(new City("Иннополис", "otradny.png"));
            RespublicTatarstan.AddCities(new City("Казань", "kazan.png"));
            RespublicTatarstan.AddCities(new City("Кукмор", "kukmor.png"));
            RespublicTatarstan.AddCities(new City("Лаишево", "laishevo.png"));
            RespublicTatarstan.AddCities(new City("Лениногорск", "leninogorsk.png"));
            RespublicTatarstan.AddCities(new City("Мамадыш", "mamadysh.png"));
            RespublicTatarstan.AddCities(new City("Менделеевск", "mendeleevsk.png"));
            RespublicTatarstan.AddCities(new City("Мензелинск", "menzelinsk.png"));
            RespublicTatarstan.AddCities(new City("Набережные Челны", "naberezhnyechelny.png"));
            RespublicTatarstan.AddCities(new City("Нижнекамск", "nizhnekamsk.png"));
            RespublicTatarstan.AddCities(new City("Нурлат", "nurlat.png"));
            RespublicTatarstan.AddCities(new City("Тетюши", "tetiushi.png"));
            RespublicTatarstan.AddCities(new City("Чистополь", "chapaevsk.png"));

            RespublicTatarstan.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicTatarstan);
        }
    }
}
