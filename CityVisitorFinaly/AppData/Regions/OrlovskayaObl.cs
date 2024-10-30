using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Орловская области
        /// </summary>
        public void OrlovskayaObl()  
        {
            Regions OrlovskayaObl = new Regions("Орловская область", "orelobl.png")
            {
                IdRegionsMaps = "path142"
            };

            OrlovskayaObl.AddCities(new City("Болхов", "bolkhov.png"));
            OrlovskayaObl.AddCities(new City("Дмитровск", "dmitrovsk.png"));
            OrlovskayaObl.AddCities(new City("Ливны", "livny.png"));
            OrlovskayaObl.AddCities(new City("Малоархангельск", "maloarkhangelsk.png"));
            OrlovskayaObl.AddCities(new City("Мценск", "mtsensk.png"));
            OrlovskayaObl.AddCities(new City("Новосиль", "novosil.png"));
            OrlovskayaObl.AddCities(new City("Орёл", "orel.png"));

            AddRegToDB(OrlovskayaObl);
        }
    }
}
