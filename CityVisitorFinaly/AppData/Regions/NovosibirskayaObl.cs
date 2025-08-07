using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Новосибирской области
        /// </summary>
        public void NovosibirskayaObl()
        {
            Regions NovosibirskayaObl = new Regions("Новосибирская область", "novosibirskoblast.png")
            {
                IdRegionsMaps = "path136"
            };

            NovosibirskayaObl.AddCities(new City("Барабинск", "barabinsk.png"));
            NovosibirskayaObl.AddCities(new City("Бердск", "berdsk.png"));
            NovosibirskayaObl.AddCities(new City("Болотное", "bolotnoe.png"));
            NovosibirskayaObl.AddCities(new City("Искитим", "iskitim.png"));
            NovosibirskayaObl.AddCities(new City("Карасук", "karasuk.png"));
            NovosibirskayaObl.AddCities(new City("Каргат", "kargat.png"));
            NovosibirskayaObl.AddCities(new City("Куйбышев", "kuibyshev.png"));
            NovosibirskayaObl.AddCities(new City("Купино", "kupino.png"));
            NovosibirskayaObl.AddCities(new City("Новосибирск", "novosibirsk.png"));
            NovosibirskayaObl.AddCities(new City("Обь", "ob.png"));
            NovosibirskayaObl.AddCities(new City("Татарск", "tatarsk.png"));
            NovosibirskayaObl.AddCities(new City("Тогучин", "toguchin.png"));
            NovosibirskayaObl.AddCities(new City("Черепаново", "cherepanovo.png"));
            NovosibirskayaObl.AddCities(new City("Чулым", "chulym.png"));
            NovosibirskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(NovosibirskayaObl);
        }
    }
}
