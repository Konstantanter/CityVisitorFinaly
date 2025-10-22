using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Архангельской области
        /// </summary>
        public void ArkhangelskObl()
        {
            Regions ArkhangelskObl = new Regions("Архангельская область", "arkhangelskoblast.png")
            {
                IdRegionsMaps = "path88"
            };
            ArkhangelskObl.AddCities(new City("Архангельск", "arhangelsk.png"));
            ArkhangelskObl.AddCities(new City("Вельск", "velsk.png"));
            ArkhangelskObl.AddCities(new City("Каргополь", "kargopol.png"));
            ArkhangelskObl.AddCities(new City("Коряжма", "koryazhma.png"));
            ArkhangelskObl.AddCities(new City("Котлас", "kotlas.png"));
            ArkhangelskObl.AddCities(new City("Мезень", "mezen.png"));
            ArkhangelskObl.AddCities(new City("Мирный", "mirny.png"));
            ArkhangelskObl.AddCities(new City("Новодвинск", "novodvinsk.png"));
            ArkhangelskObl.AddCities(new City("Няндома", "nyandoma.png"));
            ArkhangelskObl.AddCities(new City("Онега", "onega.png"));
            ArkhangelskObl.AddCities(new City("Северодвинск", "severodvinsk.png"));
            ArkhangelskObl.AddCities(new City("Сольвычегорск", "solvychegodsk.png"));
            ArkhangelskObl.AddCities(new City("Шенкуринск", "shenkursk.png"));
            ArkhangelskObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(ArkhangelskObl);
        }
    }
}
