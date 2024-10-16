using CityVisitorFinaly.AppData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация городов (в случае их отсутствия)
        /// </summary>
        public void InitCities()
        {
            //////////////////////////////////////////////////////////////////////////
            Regions Adygea = new Regions("Республика Адыгея", "adygea.png")
            {
                IdRegionsMaps = "path16"
            };
            City Adygeisk = new City("Адыгейск", "adygeisk.png");
            City Maykop = new City("Майкоп", "maykop.png");

            Adygea.AddCities(Adygeisk);
            Adygea.AddCities(Maykop);
            AddRegToDB(Adygea);
            //////////////////////////////////////////////////////////////////////////

            Regions KrasnodarKrai = new Regions("Краснодарский край", "KrasnodarKrai.png")
            {
                IdRegionsMaps = "path72"
            };
            City Abinsk = new City("Абинск", "Abinsk.png");
            City Anapa = new City("Анапа", "Anapa.png");
            City Apsheronsk = new City("Апшеронск", "Apsheronsk.png");
            City Armavir = new City("Армавир", "Armavir.png");
            City Belorechensk = new City("Белореченск", "Belorechensk.png");
            City Gelendzhik = new City("Геленджик", "Gelendzhik.png");
            City Goryachy_Klyuch = new City("Горячий Ключ", "Goryachy_Klyuch.png");
            City Gulkevichi = new City("Гулькевичи", "Gulkevichi.png");
            City Eysk = new City("Ейск", "Eysk.png");
            City Korenovsk = new City("Кореновск", "Korenovsk.png");
            City Krasnodar = new City("Краснодар", "Krasnodar.png");
            City Kropotkin = new City("Кропоткин", "Kropotkin.png");
            City Krymsk = new City("Крымск", "Krymsk.png");
            City Kurganinsk = new City("Курганинск", "Kurganinsk.png");
            City Labinsk = new City("Лабинск", "Labinsk.png");
            City Novokubansk = new City("Новокубанск", "Novokubansk.png");
            City Novorossiysk = new City("Новороссийск", "Novorossiysk.png");
            City PrimorskoAkhtarsk = new City("Приморско-Ахтарск", "PrimorskoAkhtarsk.png");
            City SlavyansknaKubani = new City("Свавянск-на-Кубани", "SlavyansknaKubani.png");
            City Sochi = new City("Сочи", "Sochi.png");
            City Temryuk = new City("Темрюк", "Temryuk.png");
            City Timashevsk = new City("Тимашёвск", "Timashevsk.png");
            City Tikhoretsk = new City("Тихорецк", "Tikhoretsk.png");
            City Tuapse = new City("Туапсе", "Tuapse.png");
            City UstLabinsk = new City("Усть-Лабинск", "UstLabinsk.png");
            City Khadyzhensk = new City("Хадыженск", "Khadyzhensk.png");

            KrasnodarKrai.AddCities(Abinsk);
            KrasnodarKrai.AddCities(Anapa);
            KrasnodarKrai.AddCities(Apsheronsk);
            KrasnodarKrai.AddCities(Armavir);
            KrasnodarKrai.AddCities(Belorechensk);
            KrasnodarKrai.AddCities(Gelendzhik);
            KrasnodarKrai.AddCities(Goryachy_Klyuch);
            KrasnodarKrai.AddCities(Gulkevichi);
            KrasnodarKrai.AddCities(Eysk);
            KrasnodarKrai.AddCities(Korenovsk);
            KrasnodarKrai.AddCities(Krasnodar);
            KrasnodarKrai.AddCities(Kropotkin);
            KrasnodarKrai.AddCities(Krymsk);
            KrasnodarKrai.AddCities(Kurganinsk);
            KrasnodarKrai.AddCities(Labinsk);
            KrasnodarKrai.AddCities(Novokubansk);
            KrasnodarKrai.AddCities(Novorossiysk);
            KrasnodarKrai.AddCities(PrimorskoAkhtarsk);
            KrasnodarKrai.AddCities(SlavyansknaKubani);
            KrasnodarKrai.AddCities(Sochi);
            KrasnodarKrai.AddCities(Temryuk);
            KrasnodarKrai.AddCities(Timashevsk);
            KrasnodarKrai.AddCities(Tikhoretsk);
            KrasnodarKrai.AddCities(Tuapse);
            KrasnodarKrai.AddCities(UstLabinsk);
            KrasnodarKrai.AddCities(Khadyzhensk);
            AddRegToDB(KrasnodarKrai);
            //////////////////////////////////////////////////////////////////////////
            Regions RostovObl = new Regions("Ростовская область", "RostovObl.png")
            {
                IdRegionsMaps = "path148"
            };
            City Azov = new City("Азов", "Azov.png");
            City Aksai = new City("Аксай", "Aksai.png");
            City Bataisk = new City("Батайск", "Bataisk.png");
            City BelayaKalitva = new City("Белая Калитва", "BelayaKalitva.png");
            City Volgdonsk = new City("Волгодонск", "Volgdonsk.png");
            City Gukovo = new City("Гуково", "Gukovo.png");
            City Doneck = new City("Донецк", "Doneck.png");
            City Zverevo = new City("Зверево", "Zverevo.png");
            City Zernograd = new City("Зерноград", "Zernograd.png");
            City KamenskShakhtinsky = new City("Каменск-Шахтинский", "KamenskShakhtinsky.png");
            City Konstantinovsk = new City("Константиновск", "Konstantinovsk.png");
            City KrasnySulin = new City("Красный Сулин", "KrasnySulin.png");
            City Millerovo = new City("Миллерово", "Millerovo.png");
            City Morozovsk = new City("Морозовск", "Morozovsk.png");
            City Novocherkassk = new City("Новочеркасск", "Novocherkassk.png");
            City Novoshakhtinsk = new City("Новошахтинск", "Novoshakhtinsk.png");
            City Proletarsk = new City("Пролетарск", "Proletarsk.png");
            City RostovOnDon = new City("Ростов-на-Дону", "RostovOnDon.png");
            City Salsk = new City("Сальск", "Salsk.png");
            City Semikarakorsk = new City("Семикаракорск", "Semikarakorsk.png");
            City Taganrog = new City("Таганрог", "Taganrog.png");
            City Tsimlyansk = new City("Цимлянск", "Tsimlyansk.png");
            City Shahty = new City("Шахты", "Shahty.png");
            RostovObl.AddCities(Azov);
            RostovObl.AddCities(Aksai);
            RostovObl.AddCities(Bataisk);
            RostovObl.AddCities(BelayaKalitva);
            RostovObl.AddCities(Volgdonsk);
            RostovObl.AddCities(Gukovo);
            RostovObl.AddCities(Doneck);
            RostovObl.AddCities(Zverevo);
            RostovObl.AddCities(Zernograd);
            RostovObl.AddCities(KamenskShakhtinsky);
            RostovObl.AddCities(Konstantinovsk);
            RostovObl.AddCities(KrasnySulin);
            RostovObl.AddCities(Millerovo);
            RostovObl.AddCities(Morozovsk);
            RostovObl.AddCities(Novocherkassk);
            RostovObl.AddCities(Novoshakhtinsk);
            RostovObl.AddCities(Proletarsk);
            RostovObl.AddCities(RostovOnDon);
            RostovObl.AddCities(Salsk);
            RostovObl.AddCities(Semikarakorsk);
            RostovObl.AddCities(Taganrog);
            RostovObl.AddCities(Tsimlyansk);
            RostovObl.AddCities(Shahty);
            AddRegToDB(RostovObl);
            //////////////////////////////////////////////////////////////////////////
            Regions StavropolKrai = new Regions("Ставропольский край", "StavropolKrai.png")
            {
                IdRegionsMaps = "path80"
            };
            City Blagodarny = new City("Благодарный", "Blagodarny.png");
            City Budennovsk = new City("Будённовск", "Budennovsk.png");
            City Essentuki = new City("Ессентуки", "Essentuki.png");
            City Georgievsk = new City("Георгиевск", "Georgievsk.png");
            City Zheleznovodsk = new City("Железноводск", "Zheleznovodsk.png");
            City Zelenokumsk = new City("Зеленокумск", "Zelenokumsk.png");
            City Izobilny = new City("Изобильный", "Izobilny.png");
            City Ipatovo = new City("Ипатово", "Ipatovo.png");
            City Kislovodsk = new City("Кисловодск", "Kislovodsk.png");
            City Lermontov = new City("Лермонтов", "Lermontov.png");
            City MineralWaters = new City("Минеральные Воды", "MineralWaters.png");
            City Mihailovsk = new City("Михайловск", "Mihailovsk.png");
            City Nevinomyssk = new City("Невиномысск", "Nevinomyssk.png");
            City Neftekumsk = new City("Нефтекумск", "Neftekumsk.png");
            City Novoaleksandrovsk = new City("Новоалександровск", "Novoaleksandrovsk.png");
            City Novopavlovsk = new City("Новопавловск", "Novopavlovsk.png");
            City Pyatigorsk = new City("Пятигорск", "Pyatigorsk.png");
            City Svetlograd = new City("Светлоград", "Svetlograd.png");
            City Stavropol = new City("Ставрополь", "Stavropol.png");

            StavropolKrai.AddCities(Blagodarny);
            StavropolKrai.AddCities(Budennovsk);
            StavropolKrai.AddCities(Essentuki);
            StavropolKrai.AddCities(Georgievsk);
            StavropolKrai.AddCities(Zheleznovodsk);
            StavropolKrai.AddCities(Zelenokumsk);
            StavropolKrai.AddCities(Izobilny);
            StavropolKrai.AddCities(Ipatovo);
            StavropolKrai.AddCities(Kislovodsk);
            StavropolKrai.AddCities(Lermontov);
            StavropolKrai.AddCities(MineralWaters);
            StavropolKrai.AddCities(Mihailovsk);
            StavropolKrai.AddCities(Nevinomyssk);
            StavropolKrai.AddCities(Neftekumsk);
            StavropolKrai.AddCities(Novoaleksandrovsk);
            StavropolKrai.AddCities(Novopavlovsk);
            StavropolKrai.AddCities(Pyatigorsk);
            StavropolKrai.AddCities(Svetlograd);
            StavropolKrai.AddCities(Stavropol);

            AddRegToDB(StavropolKrai);
            //////////////////////////////////////////////////////////////////////////
            Regions KarachayCherkessia = new Regions("Карачаево-Черкесская республика", "KarachayCherkessia.png")
            {
                IdRegionsMaps = "path32"
            };

            City Karachay = new City("Карачаевск", "Karachay.png");
            City Teberda = new City("Теберда", "Unknow.png");
            City UstDzheguta = new City("Усть-Джегута", "Unknow.png");
            City Cherkessk = new City("Черкесск", "Cherkessk.png");

            KarachayCherkessia.AddCities(Karachay);
            KarachayCherkessia.AddCities(Teberda);
            KarachayCherkessia.AddCities(UstDzheguta);
            KarachayCherkessia.AddCities(Cherkessk);
            AddRegToDB(KarachayCherkessia);


            Regions KabardinoBalkariya = new Regions("Кабардино-Балкарская республика", "KabardinoBalkariya.png")
            {
                IdRegionsMaps = "path28"
            };

            City Baksan = new City("Баксан", "Baksan.png");
            City Mayskiy = new City("Майский", "Mayskiy.png");
            City Nalchik = new City("Нальчик", "Nalchik.png");
            City Nartkala = new City("Нарткала", "Unknow.png");

            City Prokhladny = new City("Прохладный", "Prokhladny.png");
            City Terek = new City("Терек", "Terek.png");
            City Tyrnyauz = new City("Тырныауз", "Tyrnyauz.png");
            City Сhegem = new City("Чегем", "Unknow.png");

            KabardinoBalkariya.AddCities(Baksan);
            KabardinoBalkariya.AddCities(Mayskiy);
            KabardinoBalkariya.AddCities(Nalchik);
            KabardinoBalkariya.AddCities(Nartkala);
            KabardinoBalkariya.AddCities(Prokhladny);
            KabardinoBalkariya.AddCities(Terek);
            KabardinoBalkariya.AddCities(Tyrnyauz);
            KabardinoBalkariya.AddCities(Сhegem);

            AddRegToDB(KabardinoBalkariya);
            //////////////////////////////////////////////////////////////////////////
            Regions NorthOssetiaAlania = new Regions("Республика Северная Осетия - Алания", "NorthOssetiaAlania.png")
            {
                IdRegionsMaps = "path46"
            };
            City Alagir = new City("Алагир", "Unknow.png");
            City Ardon = new City("Ардон", "Unknow.png");
            City Beslan = new City("Беслан", "Beslan.png");
            City Vladikavkaz = new City("Владикавказ", "Vladikavkaz.png");
            City Digora = new City("Дигора", "Unknow.png");
            City Mozdok = new City("Моздок", "Mozdok.png");

            NorthOssetiaAlania.AddCities(Alagir);
            NorthOssetiaAlania.AddCities(Ardon);
            NorthOssetiaAlania.AddCities(Beslan);
            NorthOssetiaAlania.AddCities(Vladikavkaz);
            NorthOssetiaAlania.AddCities(Digora);
            NorthOssetiaAlania.AddCities(Mozdok);

            AddRegToDB(NorthOssetiaAlania);
            //////////////////////////////////////////////////////////////////////////

            Regions Ingushetia = new Regions("Республика Ингушетия", "Ingushetia.png")
            {
                IdRegionsMaps = "path26"
            };

            City Karabulak = new City("Карабулак", "Karabulak.png");
            City Magas = new City("Магас", "Magas.png");
            City Malgobek = new City("Малгобек", "Malgobek.png");
            City Nazran = new City("Назрань", "Nazran.png");
            City Sunzha = new City("Сунжа", "Sunzha.png");
            Ingushetia.AddCities(Karabulak);
            Ingushetia.AddCities(Magas);
            Ingushetia.AddCities(Malgobek);
            Ingushetia.AddCities(Nazran);
            Ingushetia.AddCities(Sunzha);
            AddRegToDB(Ingushetia);
            //////////////////////////////////////////////////////////////////////////

            Regions Dagestan = new Regions("Республика Дагестан", "Dagestan.png")
            {
                IdRegionsMaps = "path24"
            };

            City Buinaksk = new City("Буйнакск", "Buinaksk.png");
            City DagestanskieOgni = new City("Дагестанские Огни", "DagestanskieOgni.png");
            City Derbent = new City("Дербент", "Derbent.png");
            City Izberbash = new City("Избербаш", "Izberbash.png");
            City Kaspiysk = new City("Каспийск", "Kaspiysk.png");
            City Kiziljurt = new City("Кизилюрт", "Kiziljurt.png");
            City Kizlyar = new City("Кизляр", "Kizlyar.png");
            City Makhachkala = new City("Махачкала", "Makhachkala.png");
            City Khasavyurt = new City("Хасавюрт", "Khasavyurt.png");
            City JujnoSukhokumsk = new City("Южно-Сухокумск", "JujnoSukhokumsk.png");
            Dagestan.AddCities(Buinaksk);
            Dagestan.AddCities(DagestanskieOgni);
            Dagestan.AddCities(Derbent);
            Dagestan.AddCities(Izberbash);
            Dagestan.AddCities(Kaspiysk);
            Dagestan.AddCities(Kiziljurt);
            Dagestan.AddCities(Kizlyar);
            Dagestan.AddCities(Makhachkala);
            Dagestan.AddCities(Khasavyurt);
            Dagestan.AddCities(JujnoSukhokumsk);

            AddRegToDB(Dagestan);
            //////////////////////////////////////////////////////////////////////////


            Regions Chechnya = new Regions("Чеченская республика", "Chechnya.png")
            {
                IdRegionsMaps = "path58"
            };

            City Argun = new City("Аргун", "Argun.png");
            City Grozny = new City("Грозный", "Grozny.png");
            City Gudermes = new City("Гудермес", "Gudermes.png");
            City Kurchaloi = new City("Курчалой", "Kurchaloi.png");
            City UrusMartan = new City("Урус-Мартан", "UrusMartan.png");
            City Shali = new City("Шали", "Shali.png");
            Chechnya.AddCities(Argun);
            Chechnya.AddCities(Grozny);
            Chechnya.AddCities(Gudermes);
            Chechnya.AddCities(Kurchaloi);
            Chechnya.AddCities(UrusMartan);
            Chechnya.AddCities(Shali);
            AddRegToDB(Chechnya);
            //////////////////////////////////////////////////////////////////////////
            Regions Kalmykiya = new Regions("Республика Калмыкия", "Kalmykiya.png")
            {
                IdRegionsMaps = "path148"
            };

            City Gorodovikovsk = new City("Городовиковск", "Gorodovikovsk.png");
            City Lagan = new City("Лагань", "Lagan.png");
            City Elista = new City("Элиста", "Elista.png");
            Kalmykiya.AddCities(Gorodovikovsk);
            Kalmykiya.AddCities(Lagan);
            Kalmykiya.AddCities(Elista);
            AddRegToDB(Kalmykiya);
            //////////////////////////////////////////////////////////////////////////
            Regions AstrakhObl = new Regions("Астраханская область", "AstrakhObl.png")
            {
                IdRegionsMaps = "path90"
            };

            City Astrakhan = new City("Астрахань", "Astrakhan.png");
            City Akhtubinsk = new City("Ахтубинск", "Akhtubinsk.png");
            City Znamensk = new City("Знаменск", "Znamensk.png");
            City Kamyzyak = new City("Камызяк", "Kamyzyak.png");
            City Narimanov = new City("Нариманов", "Narimanov.png");
            City Kharabali = new City("Харабали", "Kharabali.png");
            AstrakhObl.AddCities(Astrakhan);
            AstrakhObl.AddCities(Akhtubinsk);
            AstrakhObl.AddCities(Znamensk);
            AstrakhObl.AddCities(Kamyzyak);
            AstrakhObl.AddCities(Narimanov);
            AstrakhObl.AddCities(Kharabali);
            AddRegToDB(AstrakhObl);
            //////////////////////////////////////////////////////////////////////////
            Regions VolgogradObl = new Regions("Волгоградская область", "VolgogradObl.png")
            {
                IdRegionsMaps = "path98"
            };

            City Volgograd = new City("Волгоград", "Volgograd.png");
            City Volzhsky = new City("Волжский", "Volzhsky.png");
            City Dubovka = new City("Дубовка", "Dubovka.png");
            City Zhirnovsk = new City("Жирновск", "Zhirnovsk.png");
            City KalachnaDonu = new City("Калач-на-Дону", "KalachnaDonu.png");
            City Kamyshin = new City("Камышин", "Kamyshin.png");
            City Kotelnikovo = new City("Котельниково", "Kotelnikovo.png");
            City Kotovo = new City("Котово", "Kotovo.png");
            City Krasnoslobodsk = new City("Краснослободск", "Krasnoslobodsk.png");
            City Leninsk = new City("Ленинск", "Leninsk.png");
            City Mikhaylovka = new City("Михайловка", "Mikhaylovka.png");
            City Nikolayevsk = new City("Николаевск", "Nikolayevsk");
            City Novoanninsky = new City("Новоаннинский", "Novoanninsky.png");
            City Pallasovka = new City("Палласовка", "Pallasovka.png");
            City PetrovVal = new City("Петров Вал", "Unknow.png");
            City Serafimovich = new City("Серафимович", "Serafimovich.png");
            City Surovikino = new City("Суровикино", "Surovikino.png");
            City Uryupinsk = new City("Урюпинск", "Uryupinsk.png");
            City Frolovo = new City("Форолово", "Frolovo.png");

            VolgogradObl.AddCities(Volgograd);
            VolgogradObl.AddCities(Volzhsky);
            VolgogradObl.AddCities(Dubovka);
            VolgogradObl.AddCities(Zhirnovsk);
            VolgogradObl.AddCities(KalachnaDonu);
            VolgogradObl.AddCities(Kamyshin);
            VolgogradObl.AddCities(Kotelnikovo);
            VolgogradObl.AddCities(Kotovo);
            VolgogradObl.AddCities(Krasnoslobodsk);
            VolgogradObl.AddCities(Leninsk);
            VolgogradObl.AddCities(Mikhaylovka);
            VolgogradObl.AddCities(Nikolayevsk);
            VolgogradObl.AddCities(Novoanninsky);
            VolgogradObl.AddCities(Pallasovka);
            VolgogradObl.AddCities(PetrovVal);
            VolgogradObl.AddCities(Serafimovich);
            VolgogradObl.AddCities(Surovikino);
            VolgogradObl.AddCities(Uryupinsk);
            VolgogradObl.AddCities(Frolovo);
            AddRegToDB(VolgogradObl);
            //////////////////////////////////////////////////////////////////////////
            Regions Krym = new Regions("Республика Крым", "respublik_krym.png")
            {
                IdRegionsMaps = "path38"
            };

            City alupka = new City("Алупка", "alupka.png");
            City alusta = new City("Алушта", "alusta.png");
            City armyansk = new City("Армянск", "armyansk.png");
            City bahchisarai = new City("Бахчисарай", "bahchisarai.png");
            City belogorsk = new City("Белогорск", "belogorsk.png");
            City dzhankoi = new City("Джанкой", "dzhankoi.png");
            City evpatoriya = new City("Евпатория", "evpatoriya.png");
            City kerch = new City("Керчь", "kerch.png");
            City krasnoperekopsk = new City("Красноперекопск", "krasnoperekopsk.png");
            City saki = new City("Саки", "saki.png");
            City simferopol = new City("Симферополь", "simferopol.png");
            City staryi_krym = new City("Старый Крым", "staryi_krym.png");
            City sudak = new City("Судак", "sudak.png");
            City feodosia = new City("Феодосия", "feodosia.png");
            City shchyolkino = new City("Щёлкино", "shchyolkino.png");
            City yalta = new City("Ялта", "alupka.png");

            Krym.AddCities(alupka);
            Krym.AddCities(alusta);
            Krym.AddCities(armyansk);
            Krym.AddCities(bahchisarai);
            Krym.AddCities(belogorsk);
            Krym.AddCities(dzhankoi);
            Krym.AddCities(evpatoriya);
            Krym.AddCities(kerch);
            Krym.AddCities(krasnoperekopsk);
            Krym.AddCities(saki);
            Krym.AddCities(simferopol);
            Krym.AddCities(staryi_krym);
            Krym.AddCities(sudak);
            Krym.AddCities(feodosia);
            Krym.AddCities(shchyolkino);
            Krym.AddCities(yalta);
            AddRegToDB(Krym);
            //////////////////////////////////////////////////////////////////////////
            Regions Sevastopl = new Regions("Севастополь", "sevastopolobl.png")
            {
                IdRegionsMaps = "path188"
            };
            City balaklava = new City("Балаклава", "balaklava.png");
            City inkerman = new City("Инкерман", "inkerman.png");
            City sevastopol = new City("Севастополь", "sevastopol.png");

            Sevastopl.AddCities(balaklava);
            Sevastopl.AddCities(inkerman);
            Sevastopl.AddCities(sevastopol);
            AddRegToDB(Sevastopl);
            //////////////////////////////////////////////////////////////////////////
            Regions BelgorodskyaObl = new Regions("Белгородская область", "belgorodoblast.png")
            {
                IdRegionsMaps = "path92"
            };
            City alekseev = new City("Алексеевка", "alekseev.png");
            City belgorod = new City("Белгород", "belgorod.png");
            City biryuch = new City("Бирюч", "biryuch.png");
            City valuyki = new City("Валуйки", "valuyki.png");
            City grayvoron = new City("Грайворон", "grayvoron.png");
            City gubkin = new City("Губкин", "gubkin.png");
            City korocha = new City("Короча", "korocha.png");
            City novy_oskol = new City("Новый Оскол", "novy_oskol.png");
            City stary_oskol = new City("Старый Оскол", "stary_oskol.png");
            City stroitel = new City("Строитель", "stroitel.png");
            City shebekino = new City("Шебекино", "shebekino.png");

            BelgorodskyaObl.AddCities(alekseev);
            BelgorodskyaObl.AddCities(belgorod);
            BelgorodskyaObl.AddCities(biryuch);
            BelgorodskyaObl.AddCities(valuyki);
            BelgorodskyaObl.AddCities(grayvoron);
            BelgorodskyaObl.AddCities(gubkin);
            BelgorodskyaObl.AddCities(korocha);
            BelgorodskyaObl.AddCities(novy_oskol);
            BelgorodskyaObl.AddCities(stary_oskol);
            BelgorodskyaObl.AddCities(stroitel);
            BelgorodskyaObl.AddCities(shebekino);
            AddRegToDB(BelgorodskyaObl);
            //////////////////////////////////////////////////////////////////////////

            Regions Bryanskobl = new Regions("Брянская область", "bryanskobl.png")
            {
                IdRegionsMaps = "path94"
            };
            City bryansk = new City("Брянск", "bryansk.png");
            City dyatkovo = new City("Дятьково", "dyatkovo.png");
            City zukovsk = new City("Жуковка", "zukovsk.png");
            City zlynka = new City("Злынка", "zlynka.png");
            City karachev = new City("Карачев", "karachev.png");
            City klincy = new City("Клинцы", "klincy.png");
            City mglin = new City("Мглин", "mglin.png");
            City novozybkov = new City("Новозыбков", "novozybkov.png");
            City pochep = new City("Почеп", "pochep.png");
            City sevsk = new City("Севск", "sevsk.png");
            City seltso = new City("Сельцо", "seltso.png");
            City strarodub = new City("Стародуб", "strarodub.png");
            City suraz = new City("Сураж", "suraz.png");
            City trubchevsk = new City("Трубчевск", "trubchevsk.png");
            City unecha = new City("Унеча", "unecha.png");
            City fokino = new City("Фокино", "fokino.png");
            Bryanskobl.AddCities(bryansk);
            Bryanskobl.AddCities(dyatkovo);
            Bryanskobl.AddCities(zukovsk);
            Bryanskobl.AddCities(zlynka);
            Bryanskobl.AddCities(karachev);
            Bryanskobl.AddCities(klincy);
            Bryanskobl.AddCities(mglin);
            Bryanskobl.AddCities(novozybkov);
            Bryanskobl.AddCities(pochep);
            Bryanskobl.AddCities(sevsk);
            Bryanskobl.AddCities(seltso);
            Bryanskobl.AddCities(strarodub);
            Bryanskobl.AddCities(suraz);
            Bryanskobl.AddCities(trubchevsk);
            Bryanskobl.AddCities(unecha);
            Bryanskobl.AddCities(fokino);
            AddRegToDB(Bryanskobl);
            //////////////////////////////////////////////////////////////////////////
            Regions VladimirObl = new Regions("Владимировская область", "vladimirioblast.png")
            {
                IdRegionsMaps = "path96"
            };
            City aleksandrov = new City("Александров", "aleksandrov.png");
            City vladimir = new City("Владимир", "vladimir.png");
            City vyazniki = new City("Вязники", "vyazniki.png");
            City gorokhovets = new City("Гороховец", "gorokhovets.png");
            City guskhrustalny = new City("Гусь-Хрустальный", "guskhrustalny.png");
            City kamechkovo = new City("Камешково", "kamechkovo.png");
            City karabanovo = new City("Карабаново", "karabanovo.png");
            City kirzhach = new City("Киржач", "kirzhach.png");
            City kovrov = new City("Ковров", "kovrov.png");
            City kolch = new City("Кольчугино", "kolch.png");
            City kosteryovo = new City("Костерёво", "kosteryovo.png");
            City kurlovo = new City("Курлово", "kurlovo.png");
            City lakinsk = new City("Лакинск", "lakinsk.png");
            City melenki = new City("Меленки", "melenki.png");
            City murom = new City("Муром", "murom.png");
            City petushki = new City("Петушки", "petushki.png");
            City pokrov = new City("Покров", "pokrov.png");
            City raduzhny = new City("Радужный", "raduzhny.png");
            City sobinka = new City("Собинка", "sobinka.png");
            City strunino = new City("Струнино", "strunino.png");
            City sudogda = new City("Судогда", "sudogda.png");
            City suzdal = new City("Суздаль", "suzdal.png");
            City yurievpolskiy = new City("Юрьев-Польский", "yurievpolskiy.png");

            VladimirObl.AddCities(aleksandrov);
            VladimirObl.AddCities(vladimir);
            VladimirObl.AddCities(vyazniki);
            VladimirObl.AddCities(gorokhovets);
            VladimirObl.AddCities(guskhrustalny);
            VladimirObl.AddCities(kamechkovo);
            VladimirObl.AddCities(karabanovo);
            VladimirObl.AddCities(kirzhach);
            VladimirObl.AddCities(kovrov);
            VladimirObl.AddCities(kolch);
            VladimirObl.AddCities(kosteryovo);
            VladimirObl.AddCities(kurlovo);
            VladimirObl.AddCities(lakinsk);
            VladimirObl.AddCities(melenki);
            VladimirObl.AddCities(murom);
            VladimirObl.AddCities(petushki);
            VladimirObl.AddCities(pokrov);
            VladimirObl.AddCities(raduzhny);
            VladimirObl.AddCities(sobinka);
            VladimirObl.AddCities(strunino);
            VladimirObl.AddCities(sudogda);
            VladimirObl.AddCities(suzdal);
            VladimirObl.AddCities(yurievpolskiy);
            AddRegToDB(VladimirObl);
            //regionNames.Add("path72", "Краснодарский край");
            //regionNames.Add("path74", "Красноярский край");
            //regionNames.Add("path44", "Республика Саха (Якутия)");
            //regionNames.Add("path148", "Ростовская область");
            //regionNames.Add("path106", "Иркутская область");
            //regionNames.Add("path90", "Астраханская область");
            //regionNames.Add("path24", "Республика Дагестан");
            //regionNames.Add("path30", "Республика Калмыкия");
            //regionNames.Add("path80", "Ставропольский край");
            //regionNames.Add("path28", "Кабардино-Балкарская Республика");
            //regionNames.Add("path46", "Республика Северная-Осетия Алания");
            //regionNames.Add("path26", "Республика Игушетия");
            //regionNames.Add("path58", "Чеченская республика");
            //regionNames.Add("path98", "Волгоградская область");
            //regionNames.Add("path154", "Саратовская область");
            //regionNames.Add("path102", "Воронежская область");
            //regionNames.Add("path140", "Оренбургская область");
            //regionNames.Add("path152", "Самарская область");
            //regionNames.Add("path174", "Челябинская область");
            //regionNames.Add("path20", "Республика Башкортостан");
            //regionNames.Add("path48", "Республика Татарстан");
            //regionNames.Add("path118", "Курганская область");
            //regionNames.Add("path170", "Тюменская область");
            //regionNames.Add("path158", "Свердловская область");
            //regionNames.Add("path357", "Ханты Мансийский АО Югра");
            //regionNames.Add("path361", "Ямало Ненецкий АО");
            //regionNames.Add("path359", "Чукотский АО");
            //regionNames.Add("path70", "Камчатский край");
            //regionNames.Add("path126", "Магаданская область");
            //regionNames.Add("path82", "Хабаровский край");
            //regionNames.Add("path156", "Сахалинская область");
            //regionNames.Add("path78", "Приморский край");
            //regionNames.Add("path353", "Еврейская АО");
            //regionNames.Add("path86", "Амурская область");
            //regionNames.Add("path22", "Республика Бурятия");
            //regionNames.Add("path68", "Забайскальский край");
            //regionNames.Add("path50", "Республика Тыва");
            //regionNames.Add("path56", "Республика Хакасия");
            //regionNames.Add("path18", "Республика Алтай");
            //regionNames.Add("path166", "Томская область");
            //regionNames.Add("path136", "Новосибирская область");
            //regionNames.Add("path112", "Кемеровская область");
            //regionNames.Add("path138", "Омская область");
            //regionNames.Add("path66", "Алтайский край");
            //regionNames.Add("path88", "Архангельская область");
            //regionNames.Add("path355", "Ненецкий АО");
            //regionNames.Add("path36", "Республика Коми");
            //regionNames.Add("path188", "Севастополь");
            //regionNames.Add("path38", "Республика Крым");
            //regionNames.Add("path178", "Херсонская область");
            //regionNames.Add("path176", "Запорожская область");
            //regionNames.Add("path52", "Донецкая область");
            //regionNames.Add("path60", "Луганская область");
            //regionNames.Add("path108", "Калининградская область");
            //regionNames.Add("path130", "Мурманская область");
            //regionNames.Add("path34", "Республика Карелия");
            //regionNames.Add("path122", "Ленинградская область");
            //regionNames.Add("path146", "Псковская область");
            //regionNames.Add("path100", "Вологодская область");
            //regionNames.Add("path114", "Кировская область");
            //regionNames.Add("path54", "Удмуртская республика");
            //regionNames.Add("path76", "Пермский край");
            //regionNames.Add("path134", "Новгородская область");
            //regionNames.Add("path164", "Тверская область");
            //regionNames.Add("path160", "Смоленская область");
            //regionNames.Add("path94", "Брянская область");
            //regionNames.Add("path110", "Калужская область");
            //regionNames.Add("path128", "Московская область");
            //regionNames.Add("path184", "Москва");
            //regionNames.Add("path120", "Курская область");
            //regionNames.Add("path92", "Белгородская область");
            //regionNames.Add("path96", "Владимировская область");
            //regionNames.Add("path142", "Орловская область");
            //regionNames.Add("path124", "Липецкая область");
            //regionNames.Add("path168", "Тульская область");
            //regionNames.Add("path150", "Рязанская область");
            //regionNames.Add("path162", "Тамбовская область");
            //regionNames.Add("path144", "Пензенская область");
            //regionNames.Add("path172", "Ульяновская область");
            //regionNames.Add("path42", "Республика Мордовия");
            //regionNames.Add("path132", "Нижегородская область");
            //regionNames.Add("path62", "Республика Чувашия");
            //regionNames.Add("path40", "Республика Марий Эл");
            //regionNames.Add("path104", "Ивановская область");
            //regionNames.Add("path116", "Костромская область");
            //regionNames.Add("path180", "Ярославская область");


            BindingContext = this;
           // App.DeleteDataBase();
        }


        public void AddRegToDB(Regions region)
        {
            RegionsDB reg1 = new RegionsDB(region);
            App.Db.InsertRegion(reg1);
            AddListCitiesToDB(region.ListCities, region.IdRegion);
        }
        public void AddListCitiesToDB(ObservableCollection<City> CityList, int regionId)
        {
            foreach (City city in CityList)
            {
                CityDB CityDB = new CityDB(city, regionId);
                CityDB.InsertCity();
            }
        }
    }
}
