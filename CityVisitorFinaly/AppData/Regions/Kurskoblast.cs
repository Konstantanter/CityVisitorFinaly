using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Курской области
        /// </summary>
        public void Kurskoblast()
        {
            Regions Kurskoblast = new Regions("Курская область", "kurskoblast.png")
            {
                IdRegionsMaps = "path120"
            };

            City dmitrev = new City("Дмитриев", "dmitrev.png");
            City zelezno = new City("Железногорск", "zelezno.png");
            City kursk = new City("Курск", "kursk.png");
            City kurchatov = new City("Курчатов", "kurchatov.png");
            City lgov = new City("Льгов", "lgov.png");
            City oboyan = new City("Обоянь", "oboyan.png");
            City rylsk = new City("Рыльск", "rylsk.png");
            City sudza = new City("Суджа", "sudza.png");
            City fatezh = new City("Фатеж", "fatezh.png");
            City schigry = new City("Щигры", "schigry.png");

            Kurskoblast.AddCities(dmitrev);
            Kurskoblast.AddCities(zelezno);
            Kurskoblast.AddCities(kursk);
            Kurskoblast.AddCities(kurchatov);
            Kurskoblast.AddCities(lgov);
            Kurskoblast.AddCities(oboyan);
            Kurskoblast.AddCities(rylsk);
            Kurskoblast.AddCities(sudza);
            Kurskoblast.AddCities(fatezh);
            Kurskoblast.AddCities(schigry);

            AddRegToDB(Kurskoblast);
        }
    }
}
