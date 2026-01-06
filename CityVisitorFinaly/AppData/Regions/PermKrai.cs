using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Пензенской области
        /// </summary>
        public void RespublicBashkortostan()
        {
            Regions RespublicBashkortostan = new Regions("Республика Башкортостан", "bashkortostan.png")
            {
                IdRegionsMaps = "path20"
            };
            RespublicBashkortostan.AddCities(new City("Агидель", "agidel.png"));
            RespublicBashkortostan.AddCities(new City("Баймак", "baimak.png"));
            RespublicBashkortostan.AddCities(new City("Белебей", "belebei.png"));
            RespublicBashkortostan.AddCities(new City("Белорецк", "beloretsk.png"));
            RespublicBashkortostan.AddCities(new City("Бирск", "birsk.png"));
            RespublicBashkortostan.AddCities(new City("Благовещенск", "blagoveschenskbashkortostan.png"));
            RespublicBashkortostan.AddCities(new City("Давлеканово", "davlekanovo.png"));
            RespublicBashkortostan.AddCities(new City("Дюртюли", "durtuli.png"));
            RespublicBashkortostan.AddCities(new City("Ишимбай", "durtuli.png"));
            RespublicBashkortostan.AddCities(new City("Кумертау", "kumertau.png"));
            RespublicBashkortostan.AddCities(new City("Межгорье", "mezhgorie.png"));
            RespublicBashkortostan.AddCities(new City("Мелеуз", "meleuz.png"));
            RespublicBashkortostan.AddCities(new City("Нефтекамск", "neftekamsk.png"));
            RespublicBashkortostan.AddCities(new City("Октябрьский", "oktyabrsky.png"));
            RespublicBashkortostan.AddCities(new City("Салават", "salavat.png"));
            RespublicBashkortostan.AddCities(new City("Сибай", "sibai.png"));
            RespublicBashkortostan.AddCities(new City("Стерлитамак", "sterlitamak.png"));
            RespublicBashkortostan.AddCities(new City("Туймазы", "tuimazy.png"));
            RespublicBashkortostan.AddCities(new City("Уфа", "ufa.png"));
            RespublicBashkortostan.AddCities(new City("Учалы", "uchaly.png"));
            RespublicBashkortostan.AddCities(new City("Янаул", "yanaul.png"));

   
            RespublicBashkortostan.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicBashkortostan);
        }
    }
}
