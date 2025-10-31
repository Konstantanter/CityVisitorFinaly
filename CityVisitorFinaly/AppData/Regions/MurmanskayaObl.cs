using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Мурманской области
        /// </summary>
        public void MurmanskayaObl()
        {
            Regions MurmanskayaObl = new Regions("Мурманская область", "murmanskayaobl.png")
            {
                IdRegionsMaps = "path130"
            };
            MurmanskayaObl.AddCities(new City("Апатиты", "apatity.png"));
            MurmanskayaObl.AddCities(new City("Гаджиево", "gadzhievo.png"));
            MurmanskayaObl.AddCities(new City("Заозёрск", "zaozersk.png"));
            MurmanskayaObl.AddCities(new City("Заполярный", "zapolyarny.png"));
            MurmanskayaObl.AddCities(new City("Кандалакша", "kandalaksha.png"));
            MurmanskayaObl.AddCities(new City("Кировск", "kirovsk_murmanskaya.png"));
            MurmanskayaObl.AddCities(new City("Ковдор", "kovdor.png"));
            MurmanskayaObl.AddCities(new City("Кола", "kola.png"));
            MurmanskayaObl.AddCities(new City("Мончегорск", "monchegorsk.png"));
            MurmanskayaObl.AddCities(new City("Мурманск", "murmansk.png"));
            MurmanskayaObl.AddCities(new City("Оленегорск", "olenegorsk.png"));
            MurmanskayaObl.AddCities(new City("Островной", "ostrovnoj.png"));
            MurmanskayaObl.AddCities(new City("Полярные Зори", "polyarnye_zori.png"));
            MurmanskayaObl.AddCities(new City("Полярный", "polyarny.png"));
            MurmanskayaObl.AddCities(new City("Североморск", "severomorsk.png"));
            MurmanskayaObl.AddCities(new City("Снежногорск", "snezhnogorsk.png"));
            MurmanskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(MurmanskayaObl);
        }
    }
}
