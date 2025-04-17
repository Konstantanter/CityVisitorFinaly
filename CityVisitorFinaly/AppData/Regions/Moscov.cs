using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {

        /// <summary>
        /// Инициализация города Москва
        /// </summary>
        public void Moskov()
        {
            Regions Moscov = new Regions("город Москва", "moscovreg.png")
            {
                IdRegionsMaps = "path184"
            };

            Moscov.AddCities(new City("Москва", "moscov.png"));
            Moscov.AddCities(new City("Зеленоград", "zelenograd.png"));
            Moscov.AddCities(new City("Московский", "moskovsky.png"));
            Moscov.AddCities(new City("Троицк", "troick.png"));
            Moscov.AddCities(new City("Щербинка", "scherbinka.png"));
            Moscov.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Moscov);

        }
    }
}
