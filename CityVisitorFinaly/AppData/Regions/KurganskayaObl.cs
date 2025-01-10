using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Курганиской области
        /// </summary>
        public void KurganskayaObl()
        {
            Regions KurganskayaObl = new Regions("Курганская область", "kurganoblast.png")
            {
                IdRegionsMaps = "path118"
            };
            KurganskayaObl.AddCities(new City("Далматово", "dalmatovo.png"));
            KurganskayaObl.AddCities(new City("Катайск", "kataysk.png"));
            KurganskayaObl.AddCities(new City("Курган", "kurgan.png"));
            KurganskayaObl.AddCities(new City("Куртамыш", "kurtamysh.png"));
            KurganskayaObl.AddCities(new City("Макушино", "makusino.png"));
            KurganskayaObl.AddCities(new City("Петухово", "petukhovo.png"));
            KurganskayaObl.AddCities(new City("Шадринск", "shadrinsk.png"));
            KurganskayaObl.AddCities(new City("Шумиха", "shumikha.png"));
            KurganskayaObl.AddCities(new City("Щучье", "schuche.png"));

            AddRegToDB(KurganskayaObl);
        }
    }
}
