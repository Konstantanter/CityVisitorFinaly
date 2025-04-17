using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Смоленской области
        /// </summary>
        public void SmolenskOblast()
        {
            Regions SmolenskOblast = new Regions("Смоленская область", "smolenskoblast.png")
            {
                IdRegionsMaps = "path160"
            };
            SmolenskOblast.AddCities(new City("Велиж", "velizh.png"));
            SmolenskOblast.AddCities(new City("Вязьма", "vyazma.png"));
            SmolenskOblast.AddCities(new City("Гагарин", "gagarin.png"));
            SmolenskOblast.AddCities(new City("Демидов", "demidov.png"));
            SmolenskOblast.AddCities(new City("Десногорск", "desnogorsk.png"));
            SmolenskOblast.AddCities(new City("Дорогобуж", "dorogobuzh.png"));
            SmolenskOblast.AddCities(new City("Духовщина", "dukhovshchina.png"));
            SmolenskOblast.AddCities(new City("Ельня", "elnya.png"));
            SmolenskOblast.AddCities(new City("Починок", "pochinok.png"));
            SmolenskOblast.AddCities(new City("Рославль", "roslavl.png"));
            SmolenskOblast.AddCities(new City("Рудня", "rudnya.png"));
            SmolenskOblast.AddCities(new City("Сафоново", "safonovo.png"));
            SmolenskOblast.AddCities(new City("Смоленск", "smolensk.png"));
            SmolenskOblast.AddCities(new City("Сычёвка", "sychyovka.png"));
            SmolenskOblast.AddCities(new City("Ярцево", "yartcevo.png"));
            SmolenskOblast.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(SmolenskOblast);
        }
    }
}
