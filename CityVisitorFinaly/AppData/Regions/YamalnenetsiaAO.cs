using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ярославской области
        /// </summary>
        public void YamalnenetsiaAO()
        {
            Regions YamalnenetsiaAO = new Regions("Ямало Ненецкий АО", "yamalnenetsia.png")
            {
                IdRegionsMaps = "path361"
            };

            YamalnenetsiaAO.AddCities(new City("Губкинский", "gubkinsky.png"));
            YamalnenetsiaAO.AddCities(new City("Лабытнанги", "labytnangi.png"));
            YamalnenetsiaAO.AddCities(new City("Муравленко", "muravlenko.png"));
            YamalnenetsiaAO.AddCities(new City("Надым", "nadym.png"));
            YamalnenetsiaAO.AddCities(new City("Новый Уренгой", "novyurengoy.png"));
            YamalnenetsiaAO.AddCities(new City("Ноябрьск", "noyabrsk.png"));
            YamalnenetsiaAO.AddCities(new City("Салехард", "salekhard.png"));
            YamalnenetsiaAO.AddCities(new City("Тарко-Сале", "tarkosale.png"));
            YamalnenetsiaAO.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(YamalnenetsiaAO);
        }
    }
}
