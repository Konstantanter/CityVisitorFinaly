using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Коми
        /// </summary>
        public void RepublicKomi()
        {
            Regions RepublicKomi = new Regions("Республика Коми", "republickomi.png")
            {
                IdRegionsMaps = "path36"
            };
            RepublicKomi.AddCities(new City("Воркута", "vorkuta.png"));
            RepublicKomi.AddCities(new City("Вуктыл", "vyktyl.png"));
            RepublicKomi.AddCities(new City("Емва", "emva.png"));
            RepublicKomi.AddCities(new City("Инта", "inta.png"));
            RepublicKomi.AddCities(new City("Микунь", "mikun.png"));
            RepublicKomi.AddCities(new City("Печора", "pechora.png"));
            RepublicKomi.AddCities(new City("Сосногорск", "sosnogorsk.png"));
            RepublicKomi.AddCities(new City("Сывтывкар", "syktyvkar.png"));
            RepublicKomi.AddCities(new City("Усинск", "usinsk.png"));
            RepublicKomi.AddCities(new City("Ухта", "ukhta.png"));
 

            RepublicKomi.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RepublicKomi);
        }
    }
}
