using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Оренбургской области
        /// </summary>
        public void OrenburgObl()
        {
            Regions OrenburgObl = new Regions("Оренбургская область", "orenburgobl.png")
            {
                IdRegionsMaps = "path140"
            };
            OrenburgObl.AddCities(new City("Абдулино", "abdulino.png"));
            OrenburgObl.AddCities(new City("Бугуруслан", "buguruslan.png"));
            OrenburgObl.AddCities(new City("Бузулук", "buzuluk.png"));
            OrenburgObl.AddCities(new City("Гай", "gay.png"));
            OrenburgObl.AddCities(new City("Кувандык", "kuvandyk.png"));
            OrenburgObl.AddCities(new City("Медногорск", "mednogorsk.png"));
            OrenburgObl.AddCities(new City("Новотроицк", "novotroitsk.png"));
            OrenburgObl.AddCities(new City("Оренбург", "orenburg.png"));
            OrenburgObl.AddCities(new City("Орск", "orsk.png"));
            OrenburgObl.AddCities(new City("Соль-Илецк", "solileczk.png"));
            OrenburgObl.AddCities(new City("Сорочинск", "sorochinsk.png"));
            OrenburgObl.AddCities(new City("Ясный", "yasnyi.png"));

            OrenburgObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(OrenburgObl);
        }
    }
}
