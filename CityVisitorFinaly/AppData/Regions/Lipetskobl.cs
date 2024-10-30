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

            Lipetskobl.AddCities(new City("Грязи", "gryazi.png"));
            Lipetskobl.AddCities(new City("Данков", "dankov.png"));
            Lipetskobl.AddCities(new City("Елец", "elets.png"));
            Lipetskobl.AddCities(new City("Задонск", "zadonsk.png"));
            Lipetskobl.AddCities(new City("Лебедянь", "lebedyan.png"));
            Lipetskobl.AddCities(new City("Липецк", "lipetsk.png"));
            Lipetskobl.AddCities(new City("Усмань", "usman.png"));
            Lipetskobl.AddCities(new City("Чаплыгин", "chaplygin.png"));
            AddRegToDB(Lipetskobl);
        }
    }
}
