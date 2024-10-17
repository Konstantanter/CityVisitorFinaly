using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Брянской области
        /// </summary>
        public void Bryanskobl()
        {
            Regions Bryanskobl = new Regions("Брянская область", "bryanskobl.png")
            {
                IdRegionsMaps = "path94"
            };
            City bryansk = new City("Брянск", "bryansk.png");
            City dyatkovo = new City("Дятьково", "dyatkovo.png");
            City zukovsk = new City("Жуковка", "zukovsk.png");
            City zlynka = new City("Злынка", "zlynka.png");
            City karachev = new City("Карачев", "karachev.png");
            City klincy = new City("Клинцы", "klincy.png");
            City mglin = new City("Мглин", "mglin.png");
            City novozybkov = new City("Новозыбков", "novozybkov.png");
            City pochep = new City("Почеп", "pochep.png");
            City sevsk = new City("Севск", "sevsk.png");
            City seltso = new City("Сельцо", "seltso.png");
            City strarodub = new City("Стародуб", "strarodub.png");
            City suraz = new City("Сураж", "suraz.png");
            City trubchevsk = new City("Трубчевск", "trubchevsk.png");
            City unecha = new City("Унеча", "unecha.png");
            City fokino = new City("Фокино", "fokino.png");
            Bryanskobl.AddCities(bryansk);
            Bryanskobl.AddCities(dyatkovo);
            Bryanskobl.AddCities(zukovsk);
            Bryanskobl.AddCities(zlynka);
            Bryanskobl.AddCities(karachev);
            Bryanskobl.AddCities(klincy);
            Bryanskobl.AddCities(mglin);
            Bryanskobl.AddCities(novozybkov);
            Bryanskobl.AddCities(pochep);
            Bryanskobl.AddCities(sevsk);
            Bryanskobl.AddCities(seltso);
            Bryanskobl.AddCities(strarodub);
            Bryanskobl.AddCities(suraz);
            Bryanskobl.AddCities(trubchevsk);
            Bryanskobl.AddCities(unecha);
            Bryanskobl.AddCities(fokino);
            AddRegToDB(Bryanskobl);
        }
    }
}
