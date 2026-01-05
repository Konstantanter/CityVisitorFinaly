using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Пензенской области
        /// </summary>
        public void PenzaObl()
        {
            Regions PenzaObl = new Regions("Пензенская область", "penzaobl.png")
            {
                IdRegionsMaps = "path144"
            };
            PenzaObl.AddCities(new City("Белинский", "belinsky.png"));
            PenzaObl.AddCities(new City("Городище", "buguruslan.png"));
            PenzaObl.AddCities(new City("Заречный", "zarechny.png"));
            PenzaObl.AddCities(new City("Каменка", "kamenka.png"));
            PenzaObl.AddCities(new City("Кузнецк", "kuznetsk.png"));
            PenzaObl.AddCities(new City("Нижний Ломов", "nizhnylomov.png"));
            PenzaObl.AddCities(new City("Никольск", "nikolskpenzaobl.png"));
            PenzaObl.AddCities(new City("Пенза", "penza.png"));
            PenzaObl.AddCities(new City("Сердобск", "serdobsk.png"));
            PenzaObl.AddCities(new City("Спасск", "spassk.png"));
            PenzaObl.AddCities(new City("Сурск", "sursk.png"));

            PenzaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(PenzaObl);
        }
    }
}
