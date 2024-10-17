using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Волгоградской области
        /// </summary>
        public void VolgogradObl()
        {
            Regions VolgogradObl = new Regions("Волгоградская область", "VolgogradObl.png")
            {
                IdRegionsMaps = "path98"
            };

            City Volgograd = new City("Волгоград", "Volgograd.png");
            City Volzhsky = new City("Волжский", "Volzhsky.png");
            City Dubovka = new City("Дубовка", "Dubovka.png");
            City Zhirnovsk = new City("Жирновск", "Zhirnovsk.png");
            City KalachnaDonu = new City("Калач-на-Дону", "KalachnaDonu.png");
            City Kamyshin = new City("Камышин", "Kamyshin.png");
            City Kotelnikovo = new City("Котельниково", "Kotelnikovo.png");
            City Kotovo = new City("Котово", "Kotovo.png");
            City Krasnoslobodsk = new City("Краснослободск", "Krasnoslobodsk.png");
            City Leninsk = new City("Ленинск", "Leninsk.png");
            City Mikhaylovka = new City("Михайловка", "Mikhaylovka.png");
            City Nikolayevsk = new City("Николаевск", "Nikolayevsk");
            City Novoanninsky = new City("Новоаннинский", "Novoanninsky.png");
            City Pallasovka = new City("Палласовка", "Pallasovka.png");
            City PetrovVal = new City("Петров Вал", "Unknow.png");
            City Serafimovich = new City("Серафимович", "Serafimovich.png");
            City Surovikino = new City("Суровикино", "Surovikino.png");
            City Uryupinsk = new City("Урюпинск", "Uryupinsk.png");
            City Frolovo = new City("Форолово", "Frolovo.png");

            VolgogradObl.AddCities(Volgograd);
            VolgogradObl.AddCities(Volzhsky);
            VolgogradObl.AddCities(Dubovka);
            VolgogradObl.AddCities(Zhirnovsk);
            VolgogradObl.AddCities(KalachnaDonu);
            VolgogradObl.AddCities(Kamyshin);
            VolgogradObl.AddCities(Kotelnikovo);
            VolgogradObl.AddCities(Kotovo);
            VolgogradObl.AddCities(Krasnoslobodsk);
            VolgogradObl.AddCities(Leninsk);
            VolgogradObl.AddCities(Mikhaylovka);
            VolgogradObl.AddCities(Nikolayevsk);
            VolgogradObl.AddCities(Novoanninsky);
            VolgogradObl.AddCities(Pallasovka);
            VolgogradObl.AddCities(PetrovVal);
            VolgogradObl.AddCities(Serafimovich);
            VolgogradObl.AddCities(Surovikino);
            VolgogradObl.AddCities(Uryupinsk);
            VolgogradObl.AddCities(Frolovo);
            AddRegToDB(VolgogradObl);
        }
    }
}
