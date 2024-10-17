using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Кабардино-Балкарской Республики
        /// </summary>
        public void KabardinoBalkariya()
        {
            Regions KabardinoBalkariya = new Regions("Кабардино-Балкарская республика", "KabardinoBalkariya.png")
            {
                IdRegionsMaps = "path28"
            };

            City Baksan = new City("Баксан", "Baksan.png");
            City Mayskiy = new City("Майский", "Mayskiy.png");
            City Nalchik = new City("Нальчик", "Nalchik.png");
            City Nartkala = new City("Нарткала", "Unknow.png");
            City Prokhladny = new City("Прохладный", "Prokhladny.png");
            City Terek = new City("Терек", "Terek.png");
            City Tyrnyauz = new City("Тырныауз", "Tyrnyauz.png");
            City Сhegem = new City("Чегем", "Unknow.png");

            KabardinoBalkariya.AddCities(Baksan);
            KabardinoBalkariya.AddCities(Mayskiy);
            KabardinoBalkariya.AddCities(Nalchik);
            KabardinoBalkariya.AddCities(Nartkala);
            KabardinoBalkariya.AddCities(Prokhladny);
            KabardinoBalkariya.AddCities(Terek);
            KabardinoBalkariya.AddCities(Tyrnyauz);
            KabardinoBalkariya.AddCities(Сhegem);

            AddRegToDB(KabardinoBalkariya);
        }
    }
}
