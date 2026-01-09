using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Хабаровского края
        /// </summary>
        public void KhabarovskKrai()
        {
            Regions KhabarovskKrai = new Regions("Хабаровский край", "khabarovskkrai.png")
            {
                IdRegionsMaps = "path82"
            };

            KhabarovskKrai.AddCities(new City("Амурск", "amursk.png"));
            KhabarovskKrai.AddCities(new City("Бикин", "bikin.png"));
            KhabarovskKrai.AddCities(new City("Вяземский", "vyazemsky.png"));
            KhabarovskKrai.AddCities(new City("Комсомольск-на-Амуре", "komsomolsknaamure.png"));
            KhabarovskKrai.AddCities(new City("Николаевск-на-Амуре", "nikolaevsk_na_amure.png"));
            KhabarovskKrai.AddCities(new City("Советская Гавань", "sovietskayagavan.png"));
            KhabarovskKrai.AddCities(new City("Хабаровск", "khabarovsk.png"));

            KhabarovskKrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KhabarovskKrai);
        }
    }
}
