using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация городов (в случае их отсутствия)
        /// </summary>
        public void InitCities()
        {
            //Республика Адыгея
            RespublicAdygeya();
            //Краснодарский край
            KrasnodarKrai();
            //Ростовская область
            RostovskayaObl();
            //Ставропольский край
            StavropolKrai();
            //Карачаево Черкесская Республика
            KarachayCherkessia();
            //Кабардино Балкарская Республика
            KabardinoBalkariya();
            //Республика Северная Осетия (Алания)
            NorthOssetiaAlania();
            //Ингушетия
            Ingushetia();
            //Дагестан
            Dagestan();
            //Чечня
            Chechnya();
            //Калмыкия
            Kalmykiya();
            //Волгоградская обл.
            VolgogradObl();
            //Республика Крым
            Krym();
            //Астраханская область
            AstrakhObl();
            //Белгородская область
            BelgorodskyaObl();
            //Брянская область
            Bryanskobl();
            //Воронежская область
            VoronezhObl();
            //Ивановская область
            IvanovoOblast();
            //Калужская область
            KalugaOblast();
            //Костромская область
            KostromskayaObl();
            //Курская область
            Kurskoblast();
            //Липецкая область
            Lipetskobl();
            //Москва
            Moskov();
            //Московская область
            MoskovObl();
            //Орловская область
            OrlovskayaObl();
            //Рязанская область
            RyazanskayaObl();
            //Смоленская область
            SmolenskOblast();
            //Тамбовская область
            TambovskayaObl();
            //Тверская область
            TverskayaObl();
            //Тульская область
            TulskayaObl();
            //Ярославская область
            YaroslavskayaObl();
            //Курганская область
            KurganskayaObl();
            //Свердловская область
            SverdlovskayaObl();
            //Тюменская область
            TymenskayaObl();
            //Ханты-Мансийский Округ - Юрга
            KhantymansiyskiyAO();
            //Челябинская область
            ChelyabinskayaObl();
            //Ямало-Ненецкий АО
            YamalnenetsiaAO();
            //Алтайский край
            Altaikrai();
            //Забайкальский край
            ZabaykalskyKrai();
            //Иркутская область
            Irkutskayaobl();
            //Кемеровская область
            KemerovskayaObl();
            //КрасноярскийКрай
            KrasnoyarskiyKrai();
            //Новосибирская область
            NovosibirskayaObl();
            //Омская область
            OmskayaObl();
            //Республика Бурятия
            RespublicBuriyatiya();
            //Томская область
            TomskayaObl();
            //Республика Тыва
            RespublicTyva();
            //Республика Хакасия
            RespublicKhakasiya();
            //Архангельская область
            ArkhangelskObl();
            //Вологодская область
            VologdaOblast();
            //Калининградская область
            KaliningradObl();
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
