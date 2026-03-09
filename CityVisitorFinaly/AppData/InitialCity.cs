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
            //Ленинградская область
            LeningradObl();
            //Мурманская область
            MurmanskayaObl();
            //Ненецкий АО
            NenetsAO();
            //Новгородская область
            NovgorodObl();
            //Псковская область
            PskovObl();
            //Республика Карелия
            RespulicKareliya();
            //Республика Коми
            RepublicKomi();
            //Санкт-Петербург
            SaintpetersBurg();
            //Республика Алтай
            RespublicAltai();
            //Кировская область
            KirovObl();
            //Нижегородская область
            NizhnyNovgorodObl();
            //Оренбургская область
            OrenburgObl();
            //Пензенская область
            PenzaObl();
            //Пермиский край
            PermKrai();
            //Саратовская область
            SaratovObl();
            //Самарская область
            SamaraObl();
            //Марий Эл
            RespublicMariEl();
            //Республика Башкортостан
            RespublicBashkortostan();
            //Республика Удмуртия
            RespublicUdmurtiya();
            //Республика Чувашия
            RespublicChuvashiya();
            //Ульяновская облать
            UlyanovskayaObl();
            //Республика Татарстан
            RespublicTatarstan();
            //Владимировская область
            VladimirObl();
            //Республика Саха (Якутия)
            RespublicYakutiya();
            //Чукотский АО
            ChukotkaAO();
            //Хабаровский край
            KhabarovskKrai();
            //Сахалинская область
            SakhalinObl();
            //Приморский край
            PrimorskyiKrai();
            //Магаданская область
            MagadanskayaObl();
            //Камчатский край
            KamchatckiyKrai();
            //Еврейская АО
            EvreiskayaAO();
            //Амурская область
            AmurskayaObl();
            //Республика Мордовия
            RespublicMordovia();


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
