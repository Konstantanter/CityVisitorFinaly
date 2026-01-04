using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Нижегородской области
        /// </summary>
        public void NizhnyNovgorodObl()
        {
            Regions NizhnyNovgorodObl = new Regions("Нижегородская область", "nizhnynovgorodregion.png")
            {
                IdRegionsMaps = "path132"
            };
            NizhnyNovgorodObl.AddCities(new City("Арзамас", "arzamas.png"));
            NizhnyNovgorodObl.AddCities(new City("Балахна", "balakhna.png"));
            NizhnyNovgorodObl.AddCities(new City("Богородск", "bogorodsk.png"));
            NizhnyNovgorodObl.AddCities(new City("Бор", "bor.png"));
            NizhnyNovgorodObl.AddCities(new City("Ветлуга", "vetluga.png"));
            NizhnyNovgorodObl.AddCities(new City("Володарск", "kirs.png"));
            NizhnyNovgorodObl.AddCities(new City("Ворсма", "kotelnich.png"));
            NizhnyNovgorodObl.AddCities(new City("Выкса", "luza.png"));
            NizhnyNovgorodObl.AddCities(new City("Горбатов", "gorbatov.png"));
            NizhnyNovgorodObl.AddCities(new City("Городец", "gorodec.png"));
            NizhnyNovgorodObl.AddCities(new City("Дзержинск", "dzerzhinsk.png"));
            NizhnyNovgorodObl.AddCities(new City("Заволжье", "omutninsk.png"));
            NizhnyNovgorodObl.AddCities(new City("Княгинино", "knyaginin.png"));
            NizhnyNovgorodObl.AddCities(new City("Кстово", "kstovo.png"));
            NizhnyNovgorodObl.AddCities(new City("Кулебаки", "kulebaki.png"));
            NizhnyNovgorodObl.AddCities(new City("Лукоянов", "lukoyanov.png"));
            NizhnyNovgorodObl.AddCities(new City("Лысково", "lyskovo.png"));
            NizhnyNovgorodObl.AddCities(new City("Навашино", "navashino.png"));
            NizhnyNovgorodObl.AddCities(new City("Нижний Новгород", "nizhny_novgorod.png"));
            NizhnyNovgorodObl.AddCities(new City("Павлово", "pavlovo.png"));
            NizhnyNovgorodObl.AddCities(new City("Первомайск", "pervomaysk.png"));
            NizhnyNovgorodObl.AddCities(new City("Перевоз", "perevoz.png"));
            NizhnyNovgorodObl.AddCities(new City("Саров", "sarov.png"));
            NizhnyNovgorodObl.AddCities(new City("Семёнов", "semenov.png"));
            NizhnyNovgorodObl.AddCities(new City("Сергач", "sergach.png"));
            NizhnyNovgorodObl.AddCities(new City("Урень", "uren.png"));
            NizhnyNovgorodObl.AddCities(new City("Чкаловск", "chkalovsk.png"));
            NizhnyNovgorodObl.AddCities(new City("Шахунья", "shakhunya.png"));
            NizhnyNovgorodObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(NizhnyNovgorodObl);
        }
    }
}
