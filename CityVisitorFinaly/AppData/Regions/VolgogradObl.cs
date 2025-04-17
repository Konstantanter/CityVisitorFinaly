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

            VolgogradObl.AddCities(new City("Волгоград", "Volgograd.png"));
            VolgogradObl.AddCities(new City("Волжский", "Volzhsky.png"));
            VolgogradObl.AddCities(new City("Дубовка", "Dubovka.png"));
            VolgogradObl.AddCities(new City("Жирновск", "Zhirnovsk.png"));
            VolgogradObl.AddCities(new City("Калач-на-Дону", "KalachnaDonu.png"));
            VolgogradObl.AddCities(new City("Камышин", "Kamyshin.png"));
            VolgogradObl.AddCities(new City("Котельниково", "Kotelnikovo.png"));
            VolgogradObl.AddCities(new City("Котово", "Kotovo.png"));
            VolgogradObl.AddCities(new City("Краснослободск", "Krasnoslobodsk.png"));
            VolgogradObl.AddCities(new City("Ленинск", "Leninsk.png"));
            VolgogradObl.AddCities(new City("Михайловка", "Mikhaylovka.png"));
            VolgogradObl.AddCities(new City("Николаевск", "Nikolayevsk"));
            VolgogradObl.AddCities(new City("Новоаннинский", "Novoanninsky.png"));
            VolgogradObl.AddCities(new City("Палласовка", "Pallasovka.png"));
            VolgogradObl.AddCities(new City("Петров Вал", "Unknow.png"));
            VolgogradObl.AddCities(new City("Серафимович", "Serafimovich.png"));
            VolgogradObl.AddCities(new City("Суровикино", "Surovikino.png"));
            VolgogradObl.AddCities(new City("Урюпинск", "Uryupinsk.png"));
            VolgogradObl.AddCities(new City("Форолово", "Frolovo.png"));
            VolgogradObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(VolgogradObl);
        }
    }
}
