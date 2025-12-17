using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Псковской области области
        /// </summary>
        public void PskovObl()
        {
            Regions PskovObl = new Regions("Псковская область", "pskovoblast.png")
            {
                IdRegionsMaps = "path134"
            };
            PskovObl.AddCities(new City("Великие Луки", "velikiyeluki.png"));
            PskovObl.AddCities(new City("Гдов", "gdov.png"));
            PskovObl.AddCities(new City("Дно", "dno.png"));
            PskovObl.AddCities(new City("Невель", "nevel.png"));
            PskovObl.AddCities(new City("Новоржев", "novorzhev.png"));
            PskovObl.AddCities(new City("Новосокольники", "novosokolniki.png"));
            PskovObl.AddCities(new City("Опочка", "opochka.png"));
            PskovObl.AddCities(new City("Остров", "ostrov.png"));
            PskovObl.AddCities(new City("Печоры", "pechory.png"));
            PskovObl.AddCities(new City("Порхов", "porhov.png"));
            PskovObl.AddCities(new City("Псков", "pskov.png"));
            PskovObl.AddCities(new City("Порхов", "chudovo.png"));
            PskovObl.AddCities(new City("Пустошка", "pustoshka.png"));
            PskovObl.AddCities(new City("Пыталово", "pyitalovo.png"));
            PskovObl.AddCities(new City("Себеж", "sebezh.png"));
            PskovObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(PskovObl);
        }
    }
}
