using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Новгородской области
        /// </summary>
        public void NovgorodObl()
        {
            Regions NovgorodObl = new Regions("Новгородская область", "novgorodoblast.png")
            {
                IdRegionsMaps = "path134"
            };
            NovgorodObl.AddCities(new City("Боровичи", "borovichi.png"));
            NovgorodObl.AddCities(new City("Валдай", "valday.png"));
            NovgorodObl.AddCities(new City("Великий Новгород", "velikynovgorod.png"));
            NovgorodObl.AddCities(new City("Малая Вишера", "malayavishera.png"));
            NovgorodObl.AddCities(new City("Окуловка", "kotlas.png"));
            NovgorodObl.AddCities(new City("Пестово", "pestovo.png"));
            NovgorodObl.AddCities(new City("Сольцы", "soltsy.png"));
            NovgorodObl.AddCities(new City("Старая Русса", "starayarussa.png"));
            NovgorodObl.AddCities(new City("Холм", "kholm.png"));
            NovgorodObl.AddCities(new City("Чудово", "chudovo.png"));
            NovgorodObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(NovgorodObl);
        }
    }
}
