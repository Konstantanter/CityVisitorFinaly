using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Омской области
        /// </summary>
        public void OmskayaObl()
        {
            Regions OmskayaObl = new Regions("Омская область", "omskoblast.png")
            {
                IdRegionsMaps = "path138"
            };

            OmskayaObl.AddCities(new City("Исилькуль", "isilkul.png"));
            OmskayaObl.AddCities(new City("Калачинск", "kalachinsk.png"));
            OmskayaObl.AddCities(new City("Называевск", "nazyvaevsk.png"));
            OmskayaObl.AddCities(new City("Омск", "omsk.png"));
            OmskayaObl.AddCities(new City("Тара", "tara.png"));
            OmskayaObl.AddCities(new City("Тюкалинск", "tyukalinsk.png"));

            OmskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(OmskayaObl);
        }
    }
}
