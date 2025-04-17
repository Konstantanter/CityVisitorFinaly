using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {

        /// <summary>
        /// Инициализация Московской области
        /// </summary>
        public void MoskovObl()
        {
            Regions MoscovObl = new Regions("Московская область", "moscowoblast.png")
            {
                IdRegionsMaps = "path128"
            };

            MoscovObl.AddCities(new City("Апрелевка", "aprelevka.png"));
            MoscovObl.AddCities(new City("Балашиха", "balashikha.png"));
            MoscovObl.AddCities(new City("Белоозёрский", "beloozyorsky.png"));
            MoscovObl.AddCities(new City("Бронницы", "bronnitsy.png"));
            MoscovObl.AddCities(new City("Верея", "verea.png"));
            MoscovObl.AddCities(new City("Видное", "vidnoe.png"));
            MoscovObl.AddCities(new City("Волоколомаск", "volokolamsk.png"));
            MoscovObl.AddCities(new City("Воскресенск", "voskresensk.png"));
            MoscovObl.AddCities(new City("Высоковск", "vysokovsk.png"));
            MoscovObl.AddCities(new City("Голицыно", "golitsyno.png"));
            MoscovObl.AddCities(new City("Дедовск", "dedovsk.png"));
            MoscovObl.AddCities(new City("Дзержинский", "dzerzhinsky.png"));
            MoscovObl.AddCities(new City("Дмитров", "dimitrov.png"));
            MoscovObl.AddCities(new City("Долгопрудный", "dolgoprudny.png"));
            MoscovObl.AddCities(new City("Домодедово", "domodedovo.png"));
            MoscovObl.AddCities(new City("Дрезна", "drezna.png"));
            MoscovObl.AddCities(new City("Дубна", "dubna.png"));
            MoscovObl.AddCities(new City("Егорьевск", "yegorievsk.png"));
            MoscovObl.AddCities(new City("Жуковский", "zhukovskii.png"));
            MoscovObl.AddCities(new City("Зарайск", "zaraisk.png"));
            MoscovObl.AddCities(new City("Звенигород", "zvenigorod.png"));
            MoscovObl.AddCities(new City("Ивантеевка", "ivanteevka.png"));
            MoscovObl.AddCities(new City("Истра", "istra.png"));
            MoscovObl.AddCities(new City("Кашира", "kashira.png"));
            MoscovObl.AddCities(new City("Клин", "klin.png"));
            MoscovObl.AddCities(new City("Коломна", "kolomna.png"));
            MoscovObl.AddCities(new City("Королёв", "korolyov.png"));
            MoscovObl.AddCities(new City("Котельники", "kotelniki.png"));
            MoscovObl.AddCities(new City("Краснооармейск", "krasnoarmeisk.png"));
            MoscovObl.AddCities(new City("Красногорск", "krasnogorsk.png"));
            MoscovObl.AddCities(new City("Краснозаводск", "krasnozavodsk.png"));
            MoscovObl.AddCities(new City("Краснознаменск", "krasnoznamensk.png"));
            MoscovObl.AddCities(new City("Кубинка", "kubinka.png"));
            MoscovObl.AddCities(new City("Куровское", "kurovskoe.png"));
            MoscovObl.AddCities(new City("Ликино-Дулёно", "likinodulevo.png"));
            MoscovObl.AddCities(new City("Лобня", "lobnja.png"));
            MoscovObl.AddCities(new City("Лосино-Петровский", "losinopetrovsky.png"));
            MoscovObl.AddCities(new City("Луховицы", "luchovitsy.png"));
            MoscovObl.AddCities(new City("Лыткаркино", "lytkarino.png"));
            MoscovObl.AddCities(new City("Люберцы", "lyubertsy.png"));
            MoscovObl.AddCities(new City("Можайск", "mozhaisk.png"));
            MoscovObl.AddCities(new City("Мытищи", "mutishy.png"));
            MoscovObl.AddCities(new City("Наро-Фоминск", "narofominsk.png"));
            MoscovObl.AddCities(new City("Ногинск", "noginsk.png"));
            MoscovObl.AddCities(new City("Одинцово", "odintsovo.png"));
            MoscovObl.AddCities(new City("Озёры", "ozery.png"));
            MoscovObl.AddCities(new City("Орехово-Зуево", "orekhovozuevo.png"));
            MoscovObl.AddCities(new City("Павловский Посад", "pavlovskiyposad.png"));
            MoscovObl.AddCities(new City("Пересвет", "peresvet.png"));
            MoscovObl.AddCities(new City("Подольск", "podolsk.png"));
            MoscovObl.AddCities(new City("Протвино", "protvino.png"));
            MoscovObl.AddCities(new City("Пушкино", "pushkino.png"));
            MoscovObl.AddCities(new City("Пущино", "pushino.png"));
            MoscovObl.AddCities(new City("Раменское", "ramenskoe.png"));
            MoscovObl.AddCities(new City("Реутов", "reutov.png"));
            MoscovObl.AddCities(new City("Рошаль", "roshal.png"));
            MoscovObl.AddCities(new City("Руза", "ruza.png"));
            MoscovObl.AddCities(new City("Сергиев Посад", "sergievposad.png"));
            MoscovObl.AddCities(new City("Серпухов", "serpukhov.png"));
            MoscovObl.AddCities(new City("Солнечногорск", "solnechnogorsk.png"));
            MoscovObl.AddCities(new City("Старая Купавна", "starayakupavna.png"));
            MoscovObl.AddCities(new City("Ступино", "stupino.png"));
            MoscovObl.AddCities(new City("Талдом", "tald.png"));
            MoscovObl.AddCities(new City("Фрязино", "fryazino.png"));
            MoscovObl.AddCities(new City("Химки", "khimki.png"));
            MoscovObl.AddCities(new City("Хотьково", "hotkovo.png"));
            MoscovObl.AddCities(new City("Черноголовка", "chernogolovka.png"));
            MoscovObl.AddCities(new City("Чехов", "chekhov.png"));
            MoscovObl.AddCities(new City("Шатура", "shatura.png"));
            MoscovObl.AddCities(new City("Щёлково", "shchyolkovo.png"));
            MoscovObl.AddCities(new City("Электрогорск", "elekrogorsk.png"));
            MoscovObl.AddCities(new City("Электросталь", "elektrostal.png"));
            MoscovObl.AddCities(new City("Электроугли", "elektrougli.png"));
            MoscovObl.AddCities(new City("Яхрома", "yahroma.png"));
            MoscovObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(MoscovObl);
        }
    }
}
