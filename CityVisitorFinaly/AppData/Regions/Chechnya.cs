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

            City Argun = new City("Аргун", "Argun.png");
            City Grozny = new City("Грозный", "Grozny.png");
            City Gudermes = new City("Гудермес", "Gudermes.png");
            City Kurchaloi = new City("Курчалой", "Kurchaloi.png");
            City UrusMartan = new City("Урус-Мартан", "UrusMartan.png");
            City Shali = new City("Шали", "Shali.png");
            Chechnya.AddCities(Argun);
            Chechnya.AddCities(Grozny);
            Chechnya.AddCities(Gudermes);
            Chechnya.AddCities(Kurchaloi);
            Chechnya.AddCities(UrusMartan);
            Chechnya.AddCities(Shali);
            AddRegToDB(Chechnya);
        }
    }
}
