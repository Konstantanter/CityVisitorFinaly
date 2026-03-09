using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Приморского края
        /// </summary>
        public void KamchatckiyKrai()
        {
            Regions KamchatckiyKrai = new Regions("Приморский край", "kamchatkakrai.png")
            {
                IdRegionsMaps = "path70"
            };

            KamchatckiyKrai.AddCities(new City("Вилючинск", "viluchinsk.png"));
            KamchatckiyKrai.AddCities(new City("Елизово", "elizovo.png"));
            KamchatckiyKrai.AddCities(new City("Петропавловск-Камчатский", "petropavlovskkamchatsky.png"));

            AddRegToDB(KamchatckiyKrai);
        }
    }
}
