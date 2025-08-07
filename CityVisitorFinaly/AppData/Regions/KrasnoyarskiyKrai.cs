using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация Красноярского края
        /// </summary>
        public void KrasnoyarskiyKrai()
        {
            Regions KrasnoyarskiyKrai = new Regions("Красноярский край", "krasnoyarskkrai.png")
            {
                IdRegionsMaps = "path74"
            };

            KrasnoyarskiyKrai.AddCities(new City("Артёмовск", "arrtemovsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Ачинск", "achinsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Боготол", "bogotol.png"));
            KrasnoyarskiyKrai.AddCities(new City("Бородино", "borodino.png"));
            KrasnoyarskiyKrai.AddCities(new City("Дивногорск", "divnogorsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Дудинка", "dudinka.png"));
            KrasnoyarskiyKrai.AddCities(new City("Енисейск", "yeniseysk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Железногорск", "zheleznogorsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Заозёрный", "zaozyorny.png"));
            KrasnoyarskiyKrai.AddCities(new City("Игарка", "igarka.png"));
            KrasnoyarskiyKrai.AddCities(new City("Иланский", "ilansky.png"));
            KrasnoyarskiyKrai.AddCities(new City("Канск", "kansk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Кодинск", "kodinsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Красноярск", "krasnoyarsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Лесосибирск", "krasnoyarskkrai.png"));
            KrasnoyarskiyKrai.AddCities(new City("Минусинск", "minusinsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Назарово", "nazarovo.png"));
            KrasnoyarskiyKrai.AddCities(new City("Норильск", "norilsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Сосновоборск", "sosnovoborsk.png"));
            KrasnoyarskiyKrai.AddCities(new City("Ужур", "uzhur.png"));
            KrasnoyarskiyKrai.AddCities(new City("Уяр", "uyar.png"));
            KrasnoyarskiyKrai.AddCities(new City("Шарыпово", "sharypovo.png"));
            KrasnoyarskiyKrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KrasnoyarskiyKrai);
        }
    }
}
