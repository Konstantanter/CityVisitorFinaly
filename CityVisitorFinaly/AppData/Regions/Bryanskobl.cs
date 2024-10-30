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
            Bryanskobl.AddCities(new City("Брянск", "bryansk.png"));
            Bryanskobl.AddCities(new City("Дятьково", "dyatkovo.png"));
            Bryanskobl.AddCities(new City("Жуковка", "zukovsk.png"));
            Bryanskobl.AddCities(new City("Злынка", "zlynka.png"));
            Bryanskobl.AddCities(new City("Карачев", "karachev.png"));
            Bryanskobl.AddCities(new City("Клинцы", "klincy.png"));
            Bryanskobl.AddCities(new City("Мглин", "mglin.png"));
            Bryanskobl.AddCities(new City("Новозыбков", "novozybkov.png"));
            Bryanskobl.AddCities(new City("Почеп", "pochep.png"));
            Bryanskobl.AddCities(new City("Севск", "sevsk.png"));
            Bryanskobl.AddCities(new City("Сельцо", "seltso.png"));
            Bryanskobl.AddCities(new City("Стародуб", "strarodub.png"));
            Bryanskobl.AddCities(new City("Сураж", "suraz.png"));
            Bryanskobl.AddCities(new City("Трубчевск", "trubchevsk.png"));
            Bryanskobl.AddCities(new City("Унеча", "unecha.png"));
            Bryanskobl.AddCities(new City("Фокино", "fokino.png"));
            AddRegToDB(Bryanskobl);
        }
    }
}
