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

            IvanovoOblast.AddCities(new City("Вичуга", "vichuga.png"));
            IvanovoOblast.AddCities(new City("Гаврилов Посад", "gavrilovposad.png"));
            IvanovoOblast.AddCities(new City("Заволжск", "zavolzhsk.png"));
            IvanovoOblast.AddCities(new City("Иваново", "ivanovo.png"));
            IvanovoOblast.AddCities(new City("Кинешма", "kineshma.png"));
            IvanovoOblast.AddCities(new City("Комсомольск", "komsomi.png"));
            IvanovoOblast.AddCities(new City("Кохма", "kokhma.png"));
            IvanovoOblast.AddCities(new City("Наволоки", "navoloksk.png"));
            IvanovoOblast.AddCities(new City("Плёс", "ples.png"));
            IvanovoOblast.AddCities(new City("Приволжск", "privolzsk.png"));
            IvanovoOblast.AddCities(new City("Пучеж", "puchezh.png"));
            IvanovoOblast.AddCities(new City("Родники", "rodniki.png"));
            IvanovoOblast.AddCities(new City("Тейково", "teikovo.png"));
            IvanovoOblast.AddCities(new City("Фурманов", "furmanov.png"));
            IvanovoOblast.AddCities(new City("Шуя", "shuya.png"));
            IvanovoOblast.AddCities(new City("Южа", "yuza.png"));
            IvanovoOblast.AddCities(new City("Юрьевевц", "yurievets.png"));
            IvanovoOblast.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(IvanovoOblast);

        }
    }
}
