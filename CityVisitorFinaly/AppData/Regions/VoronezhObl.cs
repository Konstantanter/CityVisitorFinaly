using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Воронежской области
        /// </summary>
        public void VoronezhObl()
        {
            Regions VoronezhObl = new Regions("Воронежская область", "voronezhobl.png")
            {
                IdRegionsMaps = "path102"
            };

            VoronezhObl.AddCities(new City("Бобров", "bobrov.png"));
            VoronezhObl.AddCities(new City("Богучар", "boguchar.png"));
            VoronezhObl.AddCities(new City("Борисоглебск", "borisoglebsk.png"));
            VoronezhObl.AddCities(new City("Бутурлиновка", "buturlinovskoe.png"));
            VoronezhObl.AddCities(new City("Воронеж", "voronezh.png"));
            VoronezhObl.AddCities(new City("Калач", "kalach.png"));
            VoronezhObl.AddCities(new City("Лиски", "liski.png"));
            VoronezhObl.AddCities(new City("Нововоронеж", "novovoronezh.png"));
            VoronezhObl.AddCities(new City("Новохопёрск", "novochopersk.png"));
            VoronezhObl.AddCities(new City("Острогожск", "ostrogozsk.png"));
            VoronezhObl.AddCities(new City("Павловск", "pavlovsk.png"));
            VoronezhObl.AddCities(new City("Поворино", "povorino.png"));
            VoronezhObl.AddCities(new City("Россошь", "rossosh.png"));
            VoronezhObl.AddCities(new City("Семилуки", "semiluki.png"));
            VoronezhObl.AddCities(new City("Эриль", "ertil.png"));
            VoronezhObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(VoronezhObl);
        }
    }
}
