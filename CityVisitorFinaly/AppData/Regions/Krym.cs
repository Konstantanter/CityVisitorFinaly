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

            City alupka = new City("Алупка", "alupka.png");
            City alusta = new City("Алушта", "alusta.png");
            City armyansk = new City("Армянск", "armyansk.png");
            City bahchisarai = new City("Бахчисарай", "bahchisarai.png");
            City belogorsk = new City("Белогорск", "belogorsk.png");
            City dzhankoi = new City("Джанкой", "dzhankoi.png");
            City evpatoriya = new City("Евпатория", "evpatoriya.png");
            City kerch = new City("Керчь", "kerch.png");
            City krasnoperekopsk = new City("Красноперекопск", "krasnoperekopsk.png");
            City saki = new City("Саки", "saki.png");
            City simferopol = new City("Симферополь", "simferopol.png");
            City staryi_krym = new City("Старый Крым", "staryi_krym.png");
            City sudak = new City("Судак", "sudak.png");
            City feodosia = new City("Феодосия", "feodosia.png");
            City shchyolkino = new City("Щёлкино", "shchyolkino.png");
            City yalta = new City("Ялта", "alupka.png");

            Krym.AddCities(alupka);
            Krym.AddCities(alusta);
            Krym.AddCities(armyansk);
            Krym.AddCities(bahchisarai);
            Krym.AddCities(belogorsk);
            Krym.AddCities(dzhankoi);
            Krym.AddCities(evpatoriya);
            Krym.AddCities(kerch);
            Krym.AddCities(krasnoperekopsk);
            Krym.AddCities(saki);
            Krym.AddCities(simferopol);
            Krym.AddCities(staryi_krym);
            Krym.AddCities(sudak);
            Krym.AddCities(feodosia);
            Krym.AddCities(shchyolkino);
            Krym.AddCities(yalta);
            AddRegToDB(Krym);
        }
    } 
}
