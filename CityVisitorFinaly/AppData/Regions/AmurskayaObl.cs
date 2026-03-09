using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Амурской области
        /// </summary>
        public void AmurskayaObl()
        {
            Regions AmurskayaObl = new Regions("Амурская область", "amuroblast.png")
            {
                IdRegionsMaps = "path86"
            };

            AmurskayaObl.AddCities(new City("Белогорск", "belogorsk_amur.png"));
            AmurskayaObl.AddCities(new City("Благовещенск", "blagoveshchensk_amur.png"));
            AmurskayaObl.AddCities(new City("Завитинск", "zavitinsk.png"));
            AmurskayaObl.AddCities(new City("Зея", "zeya.png"));
            AmurskayaObl.AddCities(new City("Райчихинск", "raychikhinsk.png"));
            AmurskayaObl.AddCities(new City("Свободный", "svobodny.png"));
            AmurskayaObl.AddCities(new City("Сковородино", "skovorodino.png"));
            AmurskayaObl.AddCities(new City("Тында", "tynda.png"));
            AmurskayaObl.AddCities(new City("Циолковский", "zciolkovskii.png"));
            AmurskayaObl.AddCities(new City("Шимановск", "shimanovsk.png"));

           
            AddRegToDB(AmurskayaObl);
        }
    }
}
