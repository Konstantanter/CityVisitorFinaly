using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ивановская области
        /// </summary>
        public void IvanovoOblast()
        {
            Regions IvanovoOblast = new Regions("Ивановская область", "ivanovooblast.png")
            {
                IdRegionsMaps = "path104"
            };

            City vichuga = new City("Вичуга", "vichuga.png");
            City gavrilovposad = new City("Гаврилов Посад", "gavrilovposad.png");
            City zavolzhsk = new City("Заволжск", "zavolzhsk.png");
            City ivanovo = new City("Иваново", "ivanovo.png");
            City kineshma = new City("Кинешма", "kineshma.png");
            City komsomi = new City("Комсомольск", "komsomi.png");
            City kokhma = new City("Кохма", "kokhma.png");
            City navoloksk = new City("Наволоки", "navoloksk.png");
            City ples = new City("Плёс", "ples.png");
            City privolzsk = new City("Приволжск", "privolzsk.png");
            City puchezh = new City("Пучеж", "puchezh.png");
            City rodniki = new City("Родники", "rodniki.png");
            City teikovo = new City("Тейково", "teikovo.png");
            City furmanov = new City("Фурманов", "furmanov.png");
            City shuya = new City("Шуя", "shuya.png");
            City yuza = new City("Южа", "yuza.png");
            City yurievets = new City("Юрьевевц", "yurievets.png");

            IvanovoOblast.AddCities(vichuga);
            IvanovoOblast.AddCities(gavrilovposad);
            IvanovoOblast.AddCities(zavolzhsk);
            IvanovoOblast.AddCities(ivanovo);
            IvanovoOblast.AddCities(kineshma);
            IvanovoOblast.AddCities(komsomi);
            IvanovoOblast.AddCities(kokhma);
            IvanovoOblast.AddCities(navoloksk);
            IvanovoOblast.AddCities(ples);
            IvanovoOblast.AddCities(privolzsk);
            IvanovoOblast.AddCities(puchezh);
            IvanovoOblast.AddCities(rodniki);
            IvanovoOblast.AddCities(teikovo);
            IvanovoOblast.AddCities(furmanov);
            IvanovoOblast.AddCities(shuya);
            IvanovoOblast.AddCities(yuza);
            IvanovoOblast.AddCities(yurievets);
            AddRegToDB(IvanovoOblast);

        }
    }
}
