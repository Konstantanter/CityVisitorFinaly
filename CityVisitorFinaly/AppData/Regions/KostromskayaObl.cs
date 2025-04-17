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

            KostromskayaObl.AddCities(new City("Буй", "bui.png"));
            KostromskayaObl.AddCities(new City("Волгореченск", "volgorechensk.png"));
            KostromskayaObl.AddCities(new City("Галич", "galich.png"));
            KostromskayaObl.AddCities(new City("Кологрив", "kologriv.png"));
            KostromskayaObl.AddCities(new City("Кострома", "kostroma.png"));
            KostromskayaObl.AddCities(new City("Макарьев", "makarjev.png"));
            KostromskayaObl.AddCities(new City("Нерехта", "nerehta.png"));
            KostromskayaObl.AddCities(new City("Нея", "neya.png"));
            KostromskayaObl.AddCities(new City("Солигалич", "soligalich.png"));
            KostromskayaObl.AddCities(new City("Чухлома", "chuhloma.png"));
            KostromskayaObl.AddCities(new City("Шарья", "sharya.png"));
            KostromskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KostromskayaObl);
        }
    }
}
