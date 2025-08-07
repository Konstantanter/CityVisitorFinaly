using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Республики Бурятия
        /// </summary>
        public void RespublicBuriyatiya()
        {
            Regions RespublicBuriyatiya = new Regions("Республика Бурятия", "buryatia.png")
            {
                IdRegionsMaps = "path22"
            };

            RespublicBuriyatiya.AddCities(new City("Бабушкин", "babushkin.png"));
            RespublicBuriyatiya.AddCities(new City("Гусиноозёрск", "gusinoozersk.png"));
            RespublicBuriyatiya.AddCities(new City("Закаменск", "zakamensk.png"));
            RespublicBuriyatiya.AddCities(new City("Кяхта", "kyakhta.png"));
            RespublicBuriyatiya.AddCities(new City("Северобайкальск", "severobaikalsk.png"));
            RespublicBuriyatiya.AddCities(new City("Улан-Удэ", "ulanude.png"));

            RespublicBuriyatiya.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(RespublicBuriyatiya);
        }
    }
}
