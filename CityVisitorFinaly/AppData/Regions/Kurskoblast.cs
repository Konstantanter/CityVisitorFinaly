using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Курской области
        /// </summary>
        public void Kurskoblast()
        {
            Regions Kurskoblast = new Regions("Курская область", "kurskoblast.png")
            {
                IdRegionsMaps = "path120"
            };

            Kurskoblast.AddCities(new City("Дмитриев", "dmitrev.png"));
            Kurskoblast.AddCities(new City("Железногорск", "zelezno.png"));
            Kurskoblast.AddCities(new City("Курск", "kursk.png"));
            Kurskoblast.AddCities(new City("Курчатов", "kurchatov.png"));
            Kurskoblast.AddCities(new City("Льгов", "lgov.png"));
            Kurskoblast.AddCities(new City("Обоянь", "oboyan.png"));
            Kurskoblast.AddCities(new City("Рыльск", "rylsk.png"));
            Kurskoblast.AddCities(new City("Суджа", "sudza.png"));
            Kurskoblast.AddCities(new City("Фатеж", "fatezh.png"));
            Kurskoblast.AddCities(new City("Щигры", "schigry.png"));
            Kurskoblast.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Kurskoblast);
        }
    }
}
