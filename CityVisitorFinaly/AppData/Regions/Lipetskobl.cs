using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Курской области
        /// </summary>
        public void Lipetskobl()
        {
            Regions Lipetskobl = new Regions("Липецкая область", "lipetskobl.png")
            {
                IdRegionsMaps = "path124"
            };
            City gryazi = new City("Грязи", "gryazi.png");
            City dankov = new City("Данков", "dankov.png");
            City elets = new City("Елец", "elets.png");
            City zadonsk = new City("Задонск", "zadonsk.png");
            City lebedyan = new City("Лебедянь", "lebedyan.png");
            City lipetsk = new City("Липецк", "lipetsk.png");
            City usman = new City("Усмань", "usman.png");
            City chaplygin = new City("Чаплыгин", "chaplygin.png");

            Lipetskobl.AddCities(gryazi);
            Lipetskobl.AddCities(dankov);
            Lipetskobl.AddCities(elets);
            Lipetskobl.AddCities(zadonsk);
            Lipetskobl.AddCities(lebedyan);
            Lipetskobl.AddCities(lipetsk);
            Lipetskobl.AddCities(usman);
            Lipetskobl.AddCities(chaplygin);
            AddRegToDB(Lipetskobl);
        }
    }
}
