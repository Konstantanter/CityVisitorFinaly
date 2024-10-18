using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Костромской области
        /// </summary>
        public void KostromskayaObl()
        {
            Regions KostromskayaObl = new Regions("Костромская область", "kostromskayaobl.png")
            {
                IdRegionsMaps = "path116"
            };
            City bui = new City("Буй", "bui.png");
            City volgorechensk = new City("Волгореченск", "volgorechensk.png");
            City galich = new City("Галич", "galich.png");
            City kologriv = new City("Кологрив", "kologriv.png");
            City kostroma = new City("Кострома", "kostroma.png");
            City makarjev = new City("Макарьев", "makarjev.png");
            City nerehta = new City("Нерехта", "nerehta.png");
            City neya = new City("Нея", "neya.png");
            City soligalich = new City("Солигалич", "soligalich.png");
            City chuhloma = new City("Чухлома", "chuhloma.png");
            City sharya = new City("Шарья", "sharya.png");

            KostromskayaObl.AddCities(bui);
            KostromskayaObl.AddCities(volgorechensk);
            KostromskayaObl.AddCities(galich);
            KostromskayaObl.AddCities(kologriv);
            KostromskayaObl.AddCities(kostroma);
            KostromskayaObl.AddCities(makarjev);
            KostromskayaObl.AddCities(nerehta);
            KostromskayaObl.AddCities(neya);
            KostromskayaObl.AddCities(soligalich);
            KostromskayaObl.AddCities(chuhloma);
            KostromskayaObl.AddCities(sharya);

            AddRegToDB(KostromskayaObl);
        }
    }
}
