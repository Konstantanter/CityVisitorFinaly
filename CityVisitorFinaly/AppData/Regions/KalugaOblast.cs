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

            City balabanovo = new City("Балабаново", "balabanovo.png");
            City belousovo = new City("Белоусово", "belousovo.png");
            City borovsk = new City("Боровск", "borovsk.png");
            City ermolino = new City("Ермолино", "ermolino.png");
            City zhizdra = new City("Жиздра", "zhizdra.png");
            City zhukov = new City("Жуков", "zhukov.png");
            City kaluga = new City("Калуга", "kaluga.png");
            City kirov = new City("Киров", "kirov.png");
            City kozelsk = new City("Козельск", "kozelsk.png");
            City kondrovo = new City("Кондрово", "kondrovo.png");
            City kremenki = new City("Кремёнки", "kremenki.png");
            City lyudinovo = new City("Людиново", "lyudinovo.png");
            City maloyaroslavets = new City("Малоярославец", "maloyaroslavets.png");
            City medyn = new City("Медынь", "medyn.png");
            City meshchovsk = new City("Мещовск", "meshchovsk.png");
            City mosalsk = new City("Мосальск", "mosalsk.png");
            City obninsk = new City("Обнинск", "obninsk.png");
            City sosensky = new City("Сосенский", "sosensky.png");
            City demenskii = new City("Спас-Деменский", "demenskii.png");
            City sukhinichy = new City("Сухиничи", "sukhinichy.png");
            City tarusa = new City("Таруса", "tarusa.png");
            City yukhnov = new City("Юхнов", "yukhnov.png");


            KalugaOblast.AddCities(balabanovo);
            KalugaOblast.AddCities(belousovo);
            KalugaOblast.AddCities(borovsk);
            KalugaOblast.AddCities(ermolino);
            KalugaOblast.AddCities(zhizdra);
            KalugaOblast.AddCities(zhukov);
            KalugaOblast.AddCities(kaluga);
            KalugaOblast.AddCities(kirov);
            KalugaOblast.AddCities(kozelsk);
            KalugaOblast.AddCities(kondrovo);
            KalugaOblast.AddCities(kremenki);
            KalugaOblast.AddCities(lyudinovo);
            KalugaOblast.AddCities(maloyaroslavets);
            KalugaOblast.AddCities(medyn);
            KalugaOblast.AddCities(meshchovsk);
            KalugaOblast.AddCities(mosalsk);
            KalugaOblast.AddCities(obninsk);
            KalugaOblast.AddCities(sosensky);
            KalugaOblast.AddCities(demenskii);
            KalugaOblast.AddCities(sukhinichy);
            KalugaOblast.AddCities(tarusa);
            KalugaOblast.AddCities(yukhnov);
            AddRegToDB(KalugaOblast);
        }
    }
}
