using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Астраханской области
        /// </summary>
        public void Krym()
        {
            Regions Krym = new Regions("Республика Крым", "respublik_krym.png")
            {
                IdRegionsMaps = "path38"
            };

            Krym.AddCities(new City("Алупка", "alupka.png"));
            Krym.AddCities(new City("Алушта", "alusta.png"));
            Krym.AddCities(new City("Армянск", "armyansk.png"));
            Krym.AddCities(new City("Бахчисарай", "bahchisarai.png"));
            Krym.AddCities(new City("Белогорск", "belogorsk.png"));
            Krym.AddCities(new City("Джанкой", "dzhankoi.png"));
            Krym.AddCities(new City("Евпатория", "evpatoriya.png"));
            Krym.AddCities(new City("Керчь", "kerch.png"));
            Krym.AddCities(new City("Красноперекопск", "krasnoperekopsk.png"));
            Krym.AddCities(new City("Саки", "saki.png"));
            Krym.AddCities(new City("Симферополь", "simferopol.png"));
            Krym.AddCities(new City("Старый Крым", "staryi_krym.png"));
            Krym.AddCities(new City("Судак", "sudak.png"));
            Krym.AddCities(new City("Феодосия", "feodosia.png"));
            Krym.AddCities(new City("Щёлкино", "shchyolkino.png"));
            Krym.AddCities(new City("Ялта", "alupka.png"));
            Krym.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Krym);
        }
    } 
}
