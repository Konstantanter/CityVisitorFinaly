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

            City bobrov = new City("Бобров", "bobrov.png");
            City boguchar = new City("Богучар", "boguchar.png");
            City borisoglebsk = new City("Борисоглебск", "borisoglebsk.png");
            City buturlinovskoe = new City("Бутурлиновка", "buturlinovskoe.png");
            City voronezh = new City("Воронеж", "voronezh.png");
            City kalach = new City("Калач", "kalach.png");
            City liski = new City("Лиски", "liski.png");
            City novovoronezh = new City("Нововоронеж", "novovoronezh.png");
            City novochopersk = new City("Новохопёрск", "novochopersk.png");
            City ostrogozsk = new City("Острогожск", "ostrogozsk.png");
            City pavlovsk = new City("Павловск", "pavlovsk.png");
            City povorino = new City("Поворино", "povorino.png");
            City rossosh = new City("Россошь", "rossosh.png");
            City semiluki = new City("Семилуки", "semiluki.png");
            City ertil = new City("Эриль", "ertil.png");


            VoronezhObl.AddCities(bobrov);
            VoronezhObl.AddCities(boguchar);
            VoronezhObl.AddCities(borisoglebsk);
            VoronezhObl.AddCities(buturlinovskoe);
            VoronezhObl.AddCities(voronezh);
            VoronezhObl.AddCities(kalach);
            VoronezhObl.AddCities(liski);
            VoronezhObl.AddCities(novovoronezh);
            VoronezhObl.AddCities(novochopersk);
            VoronezhObl.AddCities(ostrogozsk);
            VoronezhObl.AddCities(pavlovsk);
            VoronezhObl.AddCities(povorino);
            VoronezhObl.AddCities(rossosh);
            VoronezhObl.AddCities(semiluki);
            VoronezhObl.AddCities(ertil);
            AddRegToDB(VoronezhObl);
        }
    }
}
