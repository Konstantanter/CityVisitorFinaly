using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация Кемеровской области
        /// </summary>
        public void KemerovskayaObl()
        {
            Regions KemerovskayaObl = new Regions("Кемеровская Область", "kemerovooblast.png")
            {
                IdRegionsMaps = "path112"
            };

            KemerovskayaObl.AddCities(new City("Анжеро-Сундженск", "anzherosudzhensk.png"));
            KemerovskayaObl.AddCities(new City("Белово", "belovo.png"));
            KemerovskayaObl.AddCities(new City("Берёзовский", "beryozovsky.png"));
            KemerovskayaObl.AddCities(new City("Гурьевск", "guryevsk.png"));
            KemerovskayaObl.AddCities(new City("Калтан", "kaltan.png"));
            KemerovskayaObl.AddCities(new City("Кемерово", "kemerovo.png"));
            KemerovskayaObl.AddCities(new City("Киселёвск", "kiselyovsk.png"));
            KemerovskayaObl.AddCities(new City("Ленинск-Кузнецкий", "leninskkuznezckii.png"));
            KemerovskayaObl.AddCities(new City("Мариинск", "mariinsk.png"));
            KemerovskayaObl.AddCities(new City("Междуреченск", "megdurechensk.png"));
            KemerovskayaObl.AddCities(new City("Мыски", "myski.png"));
            KemerovskayaObl.AddCities(new City("Новокузнецк", "novokuzneck.png"));
            KemerovskayaObl.AddCities(new City("Осинники", "osinniki.png"));
            KemerovskayaObl.AddCities(new City("Полысаево", "polysaevo.png"));
            KemerovskayaObl.AddCities(new City("Прокопьевск", "prokopyevsk.png"));
            KemerovskayaObl.AddCities(new City("Салаир", "salair.png"));
            KemerovskayaObl.AddCities(new City("Тайга", "taiga.png"));
            KemerovskayaObl.AddCities(new City("Таштагол", "tashtagol.png"));
            KemerovskayaObl.AddCities(new City("Топки", "topki.png"));
            KemerovskayaObl.AddCities(new City("Юрга", "yurga.png"));
            KemerovskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KemerovskayaObl);
        }
    }
}
