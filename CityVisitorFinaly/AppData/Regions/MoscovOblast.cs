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

            City aprelevka = new City("Апрелевка", "aprelevka.png");
            City balashikha = new City("Балашиха", "balashikha.png");
            City beloozyorsky = new City("Белоозёрский", "beloozyorsky.png");
            City bronnitsy = new City("Бронницы", "bronnitsy.png");
            City verea = new City("Верея", "verea.png");
            City vidnoe = new City("Видное", "vidnoe.png");
            City volokolamsk = new City("Волоколомаск", "volokolamsk.png");
            City voskresensk = new City("Воскресенск", "voskresensk.png");
            City vysokovsk = new City("Высоковск", "vysokovsk.png");
            City golitsyno = new City("Голицыно", "golitsyno.png");
            City dedovsk = new City("Дедовск", "dedovsk.png");
            City dzerzhinsky = new City("Дзержинский", "dzerzhinsky.png");
            City dimitrov = new City("Дмитров", "dimitrov.png");
            City dolgoprudny = new City("Долгопрудный", "dolgoprudny.png");
            City domodedovo = new City("Домодедово", "domodedovo.png");
            City drezna = new City("Дрезна", "drezna.png");
            City dubna = new City("Дубна", "dubna.png");
            City yegorievsk = new City("Егорьевск", "yegorievsk.png");
            City zhukovskii = new City("Жуковский", "zhukovskii.png");
            City zaraisk = new City("Зарайск", "zaraisk.png");
            City zvenigorod = new City("Звенигород", "zvenigorod.png");
            City ivanteevka = new City("Ивантеевка", "ivanteevka.png");
            City istra = new City("Истра", "istra.png");
            City kashira = new City("Кашира", "kashira.png");
            City klin = new City("Клин", "klin.png");
            City kolomna = new City("Коломна", "kolomna.png");
            City korolyov = new City("Королёв", "korolyov.png");
            City kotelniki = new City("Котельники", "kotelniki.png");
            City krasnoarmeisk = new City("Краснооармейск", "krasnoarmeisk.png");
            City krasnogorsk = new City("Красногорск", "krasnogorsk.png");
            City krasnozavodsk = new City("Краснозаводск", "krasnozavodsk.png");
            City krasnoznamensk = new City("Краснознаменск", "krasnoznamensk.png");
            City kubinka = new City("Кубинка", "kubinka.png");
            City kurovskoe = new City("Куровское", "kurovskoe.png");
            City likinodulevo = new City("Ликино-Дулёно", "likinodulevo.png");
            City lobnja = new City("Лобня", "lobnja.png");
            City losinopetrovsky = new City("Лосино-Петровский", "losinopetrovsky.png");
            City luchovitsy = new City("Луховицы", "luchovitsy.png");
            City lytkarino = new City("Лыткаркино", "lytkarino.png");
            City lyubertsy = new City("Люберцы", "lyubertsy.png");
            City mozhaisk = new City("Можайск", "mozhaisk.png");
            City mutishy = new City("Мытищи", "mutishy.png");
            City narofominsk = new City("Наро-Фоминск", "narofominsk.png");
            City noginsk = new City("Ногинск", "noginsk.png");
            City odintsovo = new City("Одинцово", "odintsovo.png");
            City ozery = new City("Озёры", "ozery.png");
            City orekhovozuevo = new City("Орехово-Зуево", "orekhovozuevo.png");
            City pavlovskiyposad = new City("Павловский Посад", "pavlovskiyposad.png");
            City peresvet = new City("Пересвет", "peresvet.png");
            City podolsk = new City("Подольск", "podolsk.png");
            City protvino = new City("Протвино", "protvino.png");
            City pushkino = new City("Пушкино", "pushkino.png");
            City pushino = new City("Пущино", "pushino.png");
            City ramenskoe = new City("Раменское", "ramenskoe.png");
            City reutov = new City("Реутов", "reutov.png");
            City roshal = new City("Рошаль", "roshal.png");
            City ruza = new City("Руза", "ruza.png");
            City sergievposad = new City("Сергиев Посад", "sergievposad.png");
            City serpukhov = new City("Серпухов", "serpukhov.png");
            City solnechnogorsk = new City("Солнечногорск", "solnechnogorsk.png");
            City starayakupavna = new City("Старая Купавна", "starayakupavna.png");
            City stupino = new City("Ступино", "stupino.png");
            City tald = new City("Талдом", "tald.png");
            City fryazino = new City("Фрязино", "fryazino.png");
            City khimki = new City("Химки", "khimki.png");
            City hotkovo = new City("Хотьково", "hotkovo.png");
            City chernogolovka = new City("Черноголовка", "chernogolovka.png");
            City chekhov = new City("Чехов", "chekhov.png");
            City shatura = new City("Шатура", "shatura.png");
            City shchyolkovo = new City("Щёлково", "shchyolkovo.png");
            City elekrogorsk = new City("Электрогорск", "elekrogorsk.png");
            City elektrostal = new City("Электросталь", "elektrostal.png");
            City elektrougli = new City("Электроугли", "elektrougli.png");
            City yahroma = new City("Яхрома", "yahroma.png");

            MoscovObl.AddCities(aprelevka);
            MoscovObl.AddCities(balashikha);
            MoscovObl.AddCities(beloozyorsky);
            MoscovObl.AddCities(bronnitsy);
            MoscovObl.AddCities(verea);
            MoscovObl.AddCities(vidnoe);
            MoscovObl.AddCities(volokolamsk);
            MoscovObl.AddCities(voskresensk);
            MoscovObl.AddCities(vysokovsk);
            MoscovObl.AddCities(golitsyno);
            MoscovObl.AddCities(dedovsk);
            MoscovObl.AddCities(dzerzhinsky);
            MoscovObl.AddCities(dimitrov);
            MoscovObl.AddCities(dolgoprudny);
            MoscovObl.AddCities(domodedovo);
            MoscovObl.AddCities(drezna);
            MoscovObl.AddCities(dubna);
            MoscovObl.AddCities(yegorievsk);
            MoscovObl.AddCities(zhukovskii);
            MoscovObl.AddCities(zaraisk);
            MoscovObl.AddCities(zvenigorod);
            MoscovObl.AddCities(ivanteevka);
            MoscovObl.AddCities(istra);
            MoscovObl.AddCities(kashira);
            MoscovObl.AddCities(klin);
            MoscovObl.AddCities(kolomna);
            MoscovObl.AddCities(korolyov);
            MoscovObl.AddCities(kotelniki);
            MoscovObl.AddCities(krasnoarmeisk);
            MoscovObl.AddCities(krasnogorsk);
            MoscovObl.AddCities(krasnozavodsk);
            MoscovObl.AddCities(krasnoznamensk);
            MoscovObl.AddCities(kubinka);
            MoscovObl.AddCities(kurovskoe);
            MoscovObl.AddCities(likinodulevo);
            MoscovObl.AddCities(lobnja);
            MoscovObl.AddCities(losinopetrovsky);
            MoscovObl.AddCities(luchovitsy);
            MoscovObl.AddCities(lytkarino);
            MoscovObl.AddCities(lyubertsy);
            MoscovObl.AddCities(mozhaisk);
            MoscovObl.AddCities(mutishy);
            MoscovObl.AddCities(narofominsk);
            MoscovObl.AddCities(noginsk);
            MoscovObl.AddCities(odintsovo);
            MoscovObl.AddCities(ozery);
            MoscovObl.AddCities(orekhovozuevo);
            MoscovObl.AddCities(pavlovskiyposad);
            MoscovObl.AddCities(peresvet);
            MoscovObl.AddCities(podolsk);
            MoscovObl.AddCities(protvino);
            MoscovObl.AddCities(pushkino);
            MoscovObl.AddCities(pushino);
            MoscovObl.AddCities(ramenskoe);
            MoscovObl.AddCities(reutov);
            MoscovObl.AddCities(roshal);
            MoscovObl.AddCities(ruza);
            MoscovObl.AddCities(sergievposad);
            MoscovObl.AddCities(serpukhov);
            MoscovObl.AddCities(solnechnogorsk);
            MoscovObl.AddCities(starayakupavna);
            MoscovObl.AddCities(stupino);
            MoscovObl.AddCities(tald);
            MoscovObl.AddCities(fryazino);
            MoscovObl.AddCities(khimki);
            MoscovObl.AddCities(hotkovo);
            MoscovObl.AddCities(chernogolovka);
            MoscovObl.AddCities(chekhov);
            MoscovObl.AddCities(shatura);
            MoscovObl.AddCities(shchyolkovo);
            MoscovObl.AddCities(elekrogorsk);
            MoscovObl.AddCities(elektrostal);
            MoscovObl.AddCities(elektrougli);
            MoscovObl.AddCities(yahroma);
            //Moscov.AddCities(zelenograd);
            //Moscov.AddCities(moskovsky);
            //Moscov.AddCities(troick);
            //Moscov.AddCities(scherbinka);
            AddRegToDB(MoscovObl);
        }
    }
}
