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
            AstrakhObl.AddCities(new City("Астрахань", "Astrakhan.png"));
            AstrakhObl.AddCities(new City("Ахтубинск", "Akhtubinsk.png"));
            AstrakhObl.AddCities(new City("Знаменск", "Znamensk.png"));
            AstrakhObl.AddCities(new City("Камызяк", "Kamyzyak.png"));
            AstrakhObl.AddCities(new City("Нариманов", "Narimanov.png"));
            AstrakhObl.AddCities(new City("Харабали", "Kharabali.png"));
            AstrakhObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(AstrakhObl);
        }
    }
}
