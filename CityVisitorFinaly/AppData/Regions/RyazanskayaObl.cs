using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Рязанской области
        /// </summary>
        public void RyazanskayaObl()
        {
            Regions RyazanskayaObl = new Regions("Рязанская область", "ryazanoblast.png")
            {
                IdRegionsMaps = "path150"
            };
            RyazanskayaObl.AddCities(new City("Касимов", "Kasimov.png"));
            RyazanskayaObl.AddCities(new City("Кораблино", "korablino.png"));
            RyazanskayaObl.AddCities(new City("Михайлов", "mihailov.png"));
            RyazanskayaObl.AddCities(new City("Новомичуринск", "novomichurinsk.png"));
            RyazanskayaObl.AddCities(new City("Ряжск", "ryazhsk.png"));
            RyazanskayaObl.AddCities(new City("Рязань", "ryazan.png"));
            RyazanskayaObl.AddCities(new City("Сасово", "sasovo.png"));
            RyazanskayaObl.AddCities(new City("Скопин", "skopin.png")); 
            RyazanskayaObl.AddCities(new City("Спас-Клепики", "spasklepiki.png"));
            RyazanskayaObl.AddCities(new City("Спасск-Рязанский", "spasskryazansky.png"));
            RyazanskayaObl.AddCities(new City("Шацк", "shatsk.png"));
            AddRegToDB(RyazanskayaObl);
        }
    }
}
