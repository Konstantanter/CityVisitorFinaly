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

            //RegionList = new ObservableCollection<Regions>();
            Regions Adygea = new Regions("Республика Адыгея", "adygea.png")
            {
                IdRegionsMaps = "path16"
            };
            City Adygeisk = new City("Адыгейск", "adygeisk.png");

           // City Maykop = new City("Майкоп", "maykop.png");

            Adygea.AddCities(Adygeisk);
           // Adygea.AddCities(Maykop);
            // RegionList.Add(Adygea);
            AddRegToDB(Adygea);
     



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
           

            //Regions RostovObl = new Regions("Ростовская область", "RostovObl.png")
            //{
            //    IdRegionsMaps = "path148"
            //};
            //City Azov = new City("Азов", "Azov.png");
            //City Aksai = new City("Аксай", "Aksai.png");
            //City Bataisk = new City("Батайск", "Bataisk.png");
            //City BelayaKalitva = new City("Белая Калитва", "BelayaKalitva.png");
            //City Volgdonsk = new City("Волгодонск", "Volgdonsk.png");
            //City Gukovo = new City("Гуково", "Gukovo.png");
            //City Doneck = new City("Донецк", "Doneck.png");

            //City Zverevo = new City("Зверево", "Zverevo.png");
            //City Zernograd = new City("Зерноград", "Zernograd.png");
            //City KamenskShakhtinsky = new City("Каменск-Шахтинский", "KamenskShakhtinsky.png");
            //City Konstantinovsk = new City("Константиновск", "Konstantinovsk.png");
            //City KrasnySulin = new City("Красный Сулин", "KrasnySulin.png");
            //City Millerovo = new City("Миллерово", "Millerovo.png");
            //City Morozovsk = new City("Морозовск", "Morozovsk.png");
            //City Novocherkassk = new City("Новочеркасск", "Novocherkassk.png");
            //City Novoshakhtinsk = new City("Новошахтинск", "Novoshakhtinsk.png");
            //City Proletarsk = new City("Пролетарск", "Proletarsk.png");
            //City RostovOnDon = new City("Ростов-на-Дону", "RostovOnDon.png");
            //City Salsk = new City("Сальск", "Salsk.png");
            //City Semikarakorsk = new City("Семикаракорск", "Semikarakorsk.png");
            //City Taganrog = new City("Таганрог", "Taganrog.png");
            //City Tsimlyansk = new City("Цимлянск", "Tsimlyansk.png");
            //City Shahty = new City("Шахтыаев", "Shahty.png");
            //RostovObl.AddCities(Azov);
            //RostovObl.AddCities(Aksai);
            //RostovObl.AddCities(Bataisk);
            //RostovObl.AddCities(BelayaKalitva);
            //RostovObl.AddCities(Volgdonsk);
            //RostovObl.AddCities(Gukovo);
            //RostovObl.AddCities(Doneck);
            //RostovObl.AddCities(Zverevo);
            //RostovObl.AddCities(Zernograd);
            //RostovObl.AddCities(KamenskShakhtinsky);
            //RostovObl.AddCities(Konstantinovsk);
            //RostovObl.AddCities(KrasnySulin);
            //RostovObl.AddCities(Millerovo);
            //RostovObl.AddCities(Morozovsk);
            //RostovObl.AddCities(Novocherkassk);
            //RostovObl.AddCities(Novoshakhtinsk);
            //RostovObl.AddCities(Proletarsk);
            //RostovObl.AddCities(RostovOnDon);
            //RostovObl.AddCities(Salsk);
            //RostovObl.AddCities(Semikarakorsk);
            //RostovObl.AddCities(Taganrog);
            //RostovObl.AddCities(Tsimlyansk);
            //RostovObl.AddCities(Shahty);
            ////RegionList.Add(RostovObl);
            //AddRegToDB(RostovObl);

            //Regions StavropolKrai = new Regions("Ставропольский край", "StavropolKrai.png")
            //{
            //    IdRegionsMaps = "path80"
            //};
            //City Blagodarny = new City("Благодарный", "Blagodarny.png");
            //City Budennovsk = new City("Будённовск", "Budennovsk.png");
            //City Essentuki = new City("Ессентуки", "Essentuki.png");
            //City Georgievsk = new City("Георгиевск", "Georgievsk.png");
            //City Zheleznovodsk = new City("Железноводск", "Zheleznovodsk.png");
            //City Zelenokumsk = new City("Зеленокумск", "Zelenokumsk.png");
            //City Izobilny = new City("Изобильный", "Izobilny.png");
            //City Ipatovo = new City("Ипатово", "Ipatovo.png");
            //City Kislovodsk = new City("Кисловодск", "Kislovodsk.png");
            //City Lermontov = new City("Лермонтов", "Lermontov.png");
            //City MineralWaters = new City("Минеральные Воды", "MineralWaters.png");
            //City Mihailovsk = new City("Михайловск", "Mihailovsk.png");
            //City Nevinomyssk = new City("Невиномысск", "Nevinomyssk.png");
            //City Neftekumsk = new City("Нефтекумск", "Neftekumsk.png");
            //City Novoaleksandrovsk = new City("Новоалександровск", "Novoaleksandrovsk.png");
            //City Novopavlovsk = new City("Новопавловск", "Novopavlovsk.png");
            //City Pyatigorsk = new City("Пятигорск", "Pyatigorsk.png");
            //City Svetlograd = new City("Светлоград", "Svetlograd.png");
            //City Stavropol = new City("Ставрополь", "Stavropol.png");



            //StavropolKrai.AddCities(Blagodarny);
            //StavropolKrai.AddCities(Budennovsk);
            //StavropolKrai.AddCities(Essentuki);
            //StavropolKrai.AddCities(Georgievsk);
            //StavropolKrai.AddCities(Zheleznovodsk);
            //StavropolKrai.AddCities(Zelenokumsk);
            //StavropolKrai.AddCities(Izobilny);
            //StavropolKrai.AddCities(Ipatovo);
            //StavropolKrai.AddCities(Kislovodsk);
            //StavropolKrai.AddCities(Lermontov);
            //StavropolKrai.AddCities(MineralWaters);
            //StavropolKrai.AddCities(Mihailovsk);
            //StavropolKrai.AddCities(Nevinomyssk);
            //StavropolKrai.AddCities(Neftekumsk);
            //StavropolKrai.AddCities(Novoaleksandrovsk);
            //StavropolKrai.AddCities(Novopavlovsk);
            //StavropolKrai.AddCities(Pyatigorsk);
            //StavropolKrai.AddCities(Svetlograd);
            //StavropolKrai.AddCities(Stavropol);

            //AddRegToDB(StavropolKrai);



            //Regions KarachayCherkessia = new Regions("Карачаево-Черкесская республика", "KarachayCherkessia.png")
            //{
            //    IdRegionsMaps = "path32"
            //};

            //City Karachay = new City("Карачаевск", "Karachay.png");
            //City Teberda = new City("Теберда", "Unknow.png");
            //City UstDzheguta = new City("Усть-Джегута", "Unknow.png");
            //City Cherkessk = new City("Черкесск", "Cherkessk.png");

            //KarachayCherkessia.AddCities(Karachay);
            //KarachayCherkessia.AddCities(Teberda);
            //KarachayCherkessia.AddCities(UstDzheguta);
            //KarachayCherkessia.AddCities(Cherkessk);
            //AddRegToDB(KarachayCherkessia);


            //Regions KabardinoBalkariya = new Regions("Кабардино-Балкарская республика", "KabardinoBalkariya.png")
            //{
            //    IdRegionsMaps = "path28"
            //};

            //City Baksan = new City("Баксан", "Baksan.png");
            //City Mayskiy = new City("Майский", "Mayskiy.png");
            //City Nalchik = new City("Нальчик", "Nalchik.png");
            //City Nartkala = new City("Нарткала", "Unknow.png");

            //City Prokhladny = new City("Прохладный", "Prokhladny.png");
            //City Terek = new City("Терек", "Terek.png");
            //City Tyrnyauz = new City("Тырныауз", "Tyrnyauz.png");
            //City Сhegem = new City("Чегем", "Unknow.png");

            //KabardinoBalkariya.AddCities(Baksan);
            //KabardinoBalkariya.AddCities(Mayskiy);
            //KabardinoBalkariya.AddCities(Nalchik);
            //KabardinoBalkariya.AddCities(Nartkala);

            //KabardinoBalkariya.AddCities(Prokhladny);
            //KabardinoBalkariya.AddCities(Terek);
            //KabardinoBalkariya.AddCities(Tyrnyauz);
            //KabardinoBalkariya.AddCities(Сhegem);

            //AddRegToDB(KabardinoBalkariya);



            //Regions NorthOssetiaAlania = new Regions("Республика Северная Осетия - Алания", "NorthOssetiaAlania.png")
            //{
            //    IdRegionsMaps = "path46"
            //};

            //City Alagir = new City("Алагир", "Unknow.png");
            //City Ardon = new City("Ардон", "Unknow.png");
            //City Beslan = new City("Беслан", "Beslan.png");
            //City Vladikavkaz = new City("Владикавказ", "Vladikavkaz.png");
            //City Digora = new City("Дигора", "Unknow.png");
            //City Mozdok = new City("Моздок", "Mozdok.png");

            //NorthOssetiaAlania.AddCities(Alagir);
            //NorthOssetiaAlania.AddCities(Ardon);
            //NorthOssetiaAlania.AddCities(Beslan);
            //NorthOssetiaAlania.AddCities(Vladikavkaz);

            //NorthOssetiaAlania.AddCities(Digora);
            //NorthOssetiaAlania.AddCities(Mozdok);

            //AddRegToDB(NorthOssetiaAlania);


            //Regions Ingushetia = new Regions("Республика Ингушетия", "Ingushetia.png")
            //{
            //    IdRegionsMaps = "path26"
            //};

            //City Karabulak = new City("Карабулак", "Karabulak.png");
            //City Magas = new City("Магас", "Magas.png");
            //City Malgobek = new City("Малгобек", "Malgobek.png");
            //City Nazran = new City("Назрань", "Nazran.png");
            //City Sunzha = new City("Сунжа", "Sunzha.png");
            ////RegionList.Add(StavropolKrai);
            //Ingushetia.AddCities(Karabulak);
            //Ingushetia.AddCities(Magas);
            //Ingushetia.AddCities(Malgobek);
            //Ingushetia.AddCities(Nazran);
            //Ingushetia.AddCities(Sunzha);
            //AddRegToDB(Ingushetia);


            //Regions Dagestan = new Regions("Республика Дагестан", "Dagestan.png")
            //{
            //    IdRegionsMaps = "path24"
            //};

            //City Buinaksk = new City("Буйнакск", "Buinaksk.png");
            //City DagestanskieOgni = new City("Дагестанские Огни", "DagestanskieOgni.png");
            //City Derbent = new City("Дербент", "Derbent.png");
            //City Izberbash = new City("Избербаш", "Izberbash.png");
            //City Kaspiysk = new City("Каспийск", "Kaspiysk.png");

            //City Kiziljurt = new City("Кизилюрт", "Kiziljurt.png");
            //City Kizlyar = new City("Кизляр", "Kizlyar.png");
            //City Makhachkala = new City("Махачкала", "Makhachkala.png");
            //City Khasavyurt = new City("Хасавюрт", "Khasavyurt.png");
            //City JujnoSukhokumsk = new City("Южно-Сухокумск", "JujnoSukhokumsk.png");

            ////RegionList.Add(StavropolKrai);
            //Dagestan.AddCities(Buinaksk);
            //Dagestan.AddCities(DagestanskieOgni);
            //Dagestan.AddCities(Derbent);
            //Dagestan.AddCities(Izberbash);
            //Dagestan.AddCities(Kaspiysk);
            //Dagestan.AddCities(Kiziljurt);
            //Dagestan.AddCities(Kizlyar);
            //Dagestan.AddCities(Makhachkala);
            //Dagestan.AddCities(Khasavyurt);
            //Dagestan.AddCities(JujnoSukhokumsk);

            //AddRegToDB(Dagestan);



            //Regions Chechnya = new Regions("Чеченская республика", "Chechnya.png")
            //{
            //    IdRegionsMaps = "path58"
            //};

            //City Argun = new City("Аргун", "Argun.png");
            //City Grozny = new City("Грозный", "Grozny.png");
            //City Gudermes = new City("Гудермес", "Gudermes.png");
            //City Kurchaloi = new City("Курчалой", "Kurchaloi.png");
            //City UrusMartan = new City("Урус-Мартан", "UrusMartan.png");
            //City Shali = new City("Шали", "Shali.png");
            //Chechnya.AddCities(Argun);
            //Chechnya.AddCities(Grozny);
            //Chechnya.AddCities(Gudermes);
            //Chechnya.AddCities(Kurchaloi);
            //Chechnya.AddCities(UrusMartan);
            //Chechnya.AddCities(Shali);
            //AddRegToDB(Chechnya);

            //Regions Kalmykiya = new Regions("Республика Калмыкия", "Kalmykiya.png")
            //{
            //    IdRegionsMaps = "path148"
            //};

            //City Gorodovikovsk = new City("Городовиковск", "Gorodovikovsk.png");
            //City Lagan = new City("Лагань", "Lagan.png");
            //City Elista = new City("Элиста", "Elista.png");
            //Kalmykiya.AddCities(Gorodovikovsk);
            //Kalmykiya.AddCities(Lagan);
            //Kalmykiya.AddCities(Elista);
            //AddRegToDB(Kalmykiya);

            //Regions AstrakhObl = new Regions("Астраханская область", "AstrakhObl.png")
            //{
            //    IdRegionsMaps = "path90"
            //};

            //City Astrakhan = new City("Астрахань", "Astrakhan.png");
            //City Akhtubinsk = new City("Ахтубинск", "Akhtubinsk.png");
            //City Znamensk = new City("Знаменск", "Znamensk.png");
            //City Kamyzyak = new City("Камызяк", "Kamyzyak.png");
            //City Narimanov = new City("Нариманов", "Narimanov.png");
            //City Kharabali = new City("Харабали", "Kharabali.png");
            //AstrakhObl.AddCities(Astrakhan);
            //AstrakhObl.AddCities(Akhtubinsk);
            //AstrakhObl.AddCities(Znamensk);
            //AstrakhObl.AddCities(Kamyzyak);
            //AstrakhObl.AddCities(Narimanov);
            //AstrakhObl.AddCities(Kharabali);
            //AddRegToDB(AstrakhObl);

            //Regions VolgogradObl = new Regions("Волгоградская область", "VolgogradObl.png")
            //{
            //    IdRegionsMaps = "path98"
            //};

            //City Volgograd = new City("Волгоград", "Volgograd.png");
            //City Volzhsky = new City("Волжский", "Volzhsky.png");
            //City Dubovka = new City("Дубовка", "Dubovka.png");
            //City Zhirnovsk = new City("Жирновск", "Zhirnovsk.png");
            //City KalachnaDonu = new City("Калач-на-Дону", "KalachnaDonu.png");
            //City Kamyshin = new City("Камышин", "Kamyshin.png");
            //City Kotelnikovo = new City("Котельниково", "Kotelnikovo.png");
            //City Kotovo = new City("Котово", "Kotovo.png");
            //City Krasnoslobodsk = new City("Краснослободск", "Krasnoslobodsk.png");
            //City Leninsk = new City("Ленинск", "Leninsk.png");
            //City Mikhaylovka = new City("Михайловка", "Mikhaylovka.png");
            //City Nikolayevsk = new City("Николаевск", "Nikolayevsk");
            //City Novoanninsky = new City("Новоаннинский", "Novoanninsky.png");
            //City Pallasovka = new City("Палласовка", "Pallasovka.png");
            //City PetrovVal = new City("Петров Вал", "Unknow.png");
            //City Serafimovich = new City("Серафимович", "Serafimovich.png");
            //City Surovikino = new City("Суровикино", "Surovikino.png");
            //City Uryupinsk = new City("Урюпинск", "Uryupinsk.png");
            //City Frolovo = new City("Форолово", "Frolovo.png");

            //VolgogradObl.AddCities(Volgograd);
            //VolgogradObl.AddCities(Volzhsky);
            //VolgogradObl.AddCities(Dubovka);
            //VolgogradObl.AddCities(Zhirnovsk);
            //VolgogradObl.AddCities(KalachnaDonu);
            //VolgogradObl.AddCities(Kamyshin);
            //VolgogradObl.AddCities(Kotelnikovo);
            //VolgogradObl.AddCities(Kotovo);
            //VolgogradObl.AddCities(Krasnoslobodsk);
            //VolgogradObl.AddCities(Leninsk);
            //VolgogradObl.AddCities(Mikhaylovka);
            //VolgogradObl.AddCities(Nikolayevsk);
            //VolgogradObl.AddCities(Novoanninsky);
            //VolgogradObl.AddCities(Pallasovka);
            //VolgogradObl.AddCities(PetrovVal);
            //VolgogradObl.AddCities(Serafimovich);
            //VolgogradObl.AddCities(Surovikino);
            //VolgogradObl.AddCities(Uryupinsk);
            //VolgogradObl.AddCities(Frolovo);
            //AddRegToDB(VolgogradObl);

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
