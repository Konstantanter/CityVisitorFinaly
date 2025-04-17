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

            KabardinoBalkariya.AddCities(new City("Баксан", "Baksan.png"));
            KabardinoBalkariya.AddCities(new City("Майский", "Mayskiy.png"));
            KabardinoBalkariya.AddCities(new City("Нальчик", "Nalchik.png"));
            KabardinoBalkariya.AddCities(new City("Нарткала", "Unknow.png"));
            KabardinoBalkariya.AddCities(new City("Прохладный", "Prokhladny.png"));
            KabardinoBalkariya.AddCities(new City("Терек", "Terek.png"));
            KabardinoBalkariya.AddCities(new City("Тырныауз", "Tyrnyauz.png"));
            KabardinoBalkariya.AddCities(new City("Чегем", "Unknow.png"));
            KabardinoBalkariya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KabardinoBalkariya);
        }
    }
}
