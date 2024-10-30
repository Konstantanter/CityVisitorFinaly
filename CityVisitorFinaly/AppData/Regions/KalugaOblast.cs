using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Калужской области
        /// </summary>
        public void KalugaOblast()
        {
            Regions KalugaOblast = new Regions("Калужская область", "kalugaoblast.png")
            {
                IdRegionsMaps = "path110"
            };

            KalugaOblast.AddCities(new City("Балабаново", "balabanovo.png"));
            KalugaOblast.AddCities(new City("Белоусово", "belousovo.png"));
            KalugaOblast.AddCities(new City("Боровск", "borovsk.png"));
            KalugaOblast.AddCities(new City("Ермолино", "ermolino.png"));
            KalugaOblast.AddCities(new City("Жиздра", "zhizdra.png"));
            KalugaOblast.AddCities(new City("Жуков", "zhukov.png"));
            KalugaOblast.AddCities(new City("Калуга", "kaluga.png"));
            KalugaOblast.AddCities(new City("Киров", "kirov.png"));
            KalugaOblast.AddCities(new City("Козельск", "kozelsk.png"));
            KalugaOblast.AddCities(new City("Кондрово", "kondrovo.png"));
            KalugaOblast.AddCities(new City("Кремёнки", "kremenki.png"));
            KalugaOblast.AddCities(new City("Людиново", "lyudinovo.png"));
            KalugaOblast.AddCities(new City("Малоярославец", "maloyaroslavets.png"));
            KalugaOblast.AddCities(new City("Медынь", "medyn.png"));
            KalugaOblast.AddCities(new City("Мещовск", "meshchovsk.png"));
            KalugaOblast.AddCities(new City("Мосальск", "mosalsk.png"));
            KalugaOblast.AddCities(new City("Обнинск", "obninsk.png"));
            KalugaOblast.AddCities(new City("Сосенский", "sosensky.png"));
            KalugaOblast.AddCities(new City("Спас-Деменский", "demenskii.png"));
            KalugaOblast.AddCities(new City("Сухиничи", "sukhinichy.png"));
            KalugaOblast.AddCities(new City("Таруса", "tarusa.png"));
            KalugaOblast.AddCities(new City("Юхнов", "yukhnov.png"));
            AddRegToDB(KalugaOblast);
        }
    }
}
