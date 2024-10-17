using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Астраханской области
        /// </summary>
        public void AstrakhObl()
        {
            Regions AstrakhObl = new Regions("Астраханская область", "AstrakhObl.png")
            {
                IdRegionsMaps = "path90"
            };

            City Astrakhan = new City("Астрахань", "Astrakhan.png");
            City Akhtubinsk = new City("Ахтубинск", "Akhtubinsk.png");
            City Znamensk = new City("Знаменск", "Znamensk.png");
            City Kamyzyak = new City("Камызяк", "Kamyzyak.png");
            City Narimanov = new City("Нариманов", "Narimanov.png");
            City Kharabali = new City("Харабали", "Kharabali.png");
            AstrakhObl.AddCities(Astrakhan);
            AstrakhObl.AddCities(Akhtubinsk);
            AstrakhObl.AddCities(Znamensk);
            AstrakhObl.AddCities(Kamyzyak);
            AstrakhObl.AddCities(Narimanov);
            AstrakhObl.AddCities(Kharabali);
            AddRegToDB(AstrakhObl);
        }
    }
}
