using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Алтайского края
        /// </summary>
        public void Altaikrai()
        {
            Regions Altaikrai = new Regions("Алтайский край", "altaikrai.png")
            {
                IdRegionsMaps = "path66"
            };
            Altaikrai.AddCities(new City("Алейск", "aleisk.png"));
            Altaikrai.AddCities(new City("Барнаул", "barnaul.png"));
            Altaikrai.AddCities(new City("Белокуриха", "belokurikha.png"));
            Altaikrai.AddCities(new City("Бийск", "biysk.png"));
            Altaikrai.AddCities(new City("Горно-Алтайск", "gornoaltaisk.png"));
            Altaikrai.AddCities(new City("Горняк", "gornyak.png"));
            Altaikrai.AddCities(new City("Заринск", "zarinsk.png"));
            Altaikrai.AddCities(new City("Змеиногорск", "zmeinogorsk.png"));
            Altaikrai.AddCities(new City("Камень-на-Оби", "kamennaobi.png"));
            Altaikrai.AddCities(new City("Новоалтайск", "novoaltaisk.png"));
            Altaikrai.AddCities(new City("Рубцовск", "rubtsovsk.png"));
            Altaikrai.AddCities(new City("Славгород", "slavgorod.png"));
            Altaikrai.AddCities(new City("Яровое", "yarovoe.png"));
            Altaikrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Altaikrai);
        }
    }
}
