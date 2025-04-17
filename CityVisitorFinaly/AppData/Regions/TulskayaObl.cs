using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Тульской области
        /// </summary>
        public void TulskayaObl()
        {
            Regions TulskayaObl = new Regions("Тульская область", "tulaoblast.png")
            {
                IdRegionsMaps = "path168"
            };
            TulskayaObl.AddCities(new City("Алексин", "aleksin.png"));
            TulskayaObl.AddCities(new City("Белёв", "belyov.png"));
            TulskayaObl.AddCities(new City("Богородицк", "bogoroditsk.png"));
            TulskayaObl.AddCities(new City("Болохово", "bolohovo.png"));
            TulskayaObl.AddCities(new City("Венёв", "venev.png"));
            TulskayaObl.AddCities(new City("Донской", "donskoy.png"));
            TulskayaObl.AddCities(new City("Ефремов", "efremov.png"));
            TulskayaObl.AddCities(new City("Кимовск", "kimovsk.png"));
            TulskayaObl.AddCities(new City("Киреевск", "kireevsk.png"));
            TulskayaObl.AddCities(new City("Липки", "lipki.png"));
            TulskayaObl.AddCities(new City("Новомосковск", "novomoskovssk.png"));
            TulskayaObl.AddCities(new City("Плавск", "plavsk.png"));
            TulskayaObl.AddCities(new City("Советск", "sovetsk.png"));
            TulskayaObl.AddCities(new City("Суворов", "suvorov.png"));
            TulskayaObl.AddCities(new City("Тула", "tula.png"));
            TulskayaObl.AddCities(new City("Узловая", "uzlovayajpeg.png"));
            TulskayaObl.AddCities(new City("Чекалин", "chekalin.png"));
            TulskayaObl.AddCities(new City("Щёкино", "rzhev.png"));
            TulskayaObl.AddCities(new City("Ясногорск", "yasnogorsk.png"));
            TulskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(TulskayaObl);
        }
    }
}
