using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация республики Чечня
        /// </summary>
        public void Chechnya()
        {
            Regions Chechnya = new Regions("Чеченская республика", "Chechnya.png")
            {
                IdRegionsMaps = "path58"
            };
            Chechnya.AddCities(new City("Аргун", "Argun.png"));
            Chechnya.AddCities(new City("Грозный", "Grozny.png"));
            Chechnya.AddCities(new City("Гудермес", "Gudermes.png"));
            Chechnya.AddCities(new City("Курчалой", "Kurchaloi.png"));
            Chechnya.AddCities(new City("Урус-Мартан", "UrusMartan.png"));
            Chechnya.AddCities(new City("Шали", "Shali.png"));
            AddRegToDB(Chechnya);
        }
    }
}
