using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Белгородской области
        /// </summary>
        public void BelgorodskyaObl()
        {
            Regions BelgorodskyaObl = new Regions("Белгородская область", "belgorodoblast.png")
            {
                IdRegionsMaps = "path92"
            };

            BelgorodskyaObl.AddCities(new City("Алексеевка", "alekseev.png"));
            BelgorodskyaObl.AddCities(new City("Белгород", "belgorod.png"));
            BelgorodskyaObl.AddCities(new City("Бирюч", "biryuch.png"));
            BelgorodskyaObl.AddCities(new City("Валуйки", "valuyki.png"));
            BelgorodskyaObl.AddCities(new City("Грайворон", "grayvoron.png"));
            BelgorodskyaObl.AddCities(new City("Губкин", "gubkin.png"));
            BelgorodskyaObl.AddCities(new City("Короча", "korocha.png"));
            BelgorodskyaObl.AddCities(new City("Новый Оскол", "novy_oskol.png"));
            BelgorodskyaObl.AddCities(new City("Старый Оскол", "stary_oskol.png"));
            BelgorodskyaObl.AddCities(new City("Строитель", "stroitel.png"));
            BelgorodskyaObl.AddCities(new City("Шебекино", "shebekino.png"));
            BelgorodskyaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(BelgorodskyaObl);
        }
    }
}
