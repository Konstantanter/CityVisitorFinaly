using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ленинградской области
        /// </summary>
        public void LeningradObl()
        {
            Regions LeningradObl = new Regions("Ленинградская область", "leningradoblast.png")
            {
                IdRegionsMaps = "path122"
            };

            LeningradObl.AddCities(new City("Богситогорск", "boksitogorsk.png"));
            LeningradObl.AddCities(new City("Волосово", "volosovo.png"));
            LeningradObl.AddCities(new City("Волхов", "volkhov.png"));
            LeningradObl.AddCities(new City("Всеволжск", "vsevolozhsk.png"));
            LeningradObl.AddCities(new City("Выборг", "vyborg.png"));
            LeningradObl.AddCities(new City("Высоцк", "vysotsk.png"));
            LeningradObl.AddCities(new City("Гатчина", "gatchina.png"));
            LeningradObl.AddCities(new City("Ивангород", "ivangorod.png"));
            LeningradObl.AddCities(new City("Каменногорск", "kamenogorsk.png"));
            LeningradObl.AddCities(new City("Кингисепп", "kingisepp.png"));
            LeningradObl.AddCities(new City("Кириши", "kirishi.png"));
            LeningradObl.AddCities(new City("Кировск", "kirovsk.png"));
            LeningradObl.AddCities(new City("Колтуши", "koltushi.png"));
            LeningradObl.AddCities(new City("Коммунар", "kommunar.png"));
            LeningradObl.AddCities(new City("Кудрово", "kudrovo.png"));
            LeningradObl.AddCities(new City("Лодейное Поле", "lodeinoepole.png"));
            LeningradObl.AddCities(new City("Луга", "luga.png"));
            LeningradObl.AddCities(new City("Любань", "luban.png"));
            LeningradObl.AddCities(new City("Мурино", "murino.png"));
            LeningradObl.AddCities(new City("Никольское", "nikolskoe.png"));
            LeningradObl.AddCities(new City("Новая Ладога", "novayaladoga.png"));
            LeningradObl.AddCities(new City("Отрадное", "otradnoe.png"));
            LeningradObl.AddCities(new City("Пикалёво", "pikalyovo.png"));
            LeningradObl.AddCities(new City("Подпорожье", "podporozhye.png"));
            LeningradObl.AddCities(new City("Приморск", "primorskleningrad.png"));
            LeningradObl.AddCities(new City("Приозёрск", "priozersk.png"));
            LeningradObl.AddCities(new City("Светлогорск", "svetogorskleningrad.png"));
            LeningradObl.AddCities(new City("Сертолово", "sertolovo.png"));
            LeningradObl.AddCities(new City("Сланцы", "slants.png"));
            LeningradObl.AddCities(new City("Сосновый Бор", "sosnovybor.png"));
            LeningradObl.AddCities(new City("Сясьстрой", "sjasstroy.png"));
            LeningradObl.AddCities(new City("Тихвин", "tikhvin.png"));
            LeningradObl.AddCities(new City("Тосно", "tosno.png"));
            LeningradObl.AddCities(new City("Шлиссельбург", "shlisselburg.png"));
            LeningradObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(LeningradObl);
        }
    }
}
