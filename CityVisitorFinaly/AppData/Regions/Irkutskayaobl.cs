using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Иркутской области
        /// </summary>
        public void Irkutskayaobl()
        {
            Regions Irkutskayaobl = new Regions("Иркутская область", "irkutskoblast.png")
            {
                IdRegionsMaps = "path106"
            };

            Irkutskayaobl.AddCities(new City("Алзамай", "almazai.png"));
            Irkutskayaobl.AddCities(new City("Ангарск", "angarsk.png"));
            Irkutskayaobl.AddCities(new City("Байкальск", "baykalsk.png"));
            Irkutskayaobl.AddCities(new City("Бирюсинск", "biryusinsk.png"));
            Irkutskayaobl.AddCities(new City("Бодайбо", "bodaibo.png"));
            Irkutskayaobl.AddCities(new City("Братск", "bratsk.png"));
            Irkutskayaobl.AddCities(new City("Вихоревка", "vihorevka.png"));
            Irkutskayaobl.AddCities(new City("Железногорск-Илимский", "zheleznogorskilimskyi.png"));
            Irkutskayaobl.AddCities(new City("Зима", "zima.png"));
            Irkutskayaobl.AddCities(new City("Иркутск", "irkutsk.png"));
            Irkutskayaobl.AddCities(new City("Киренск", "kirensk.png"));
            Irkutskayaobl.AddCities(new City("Нижнеудинск", "nizhneudinsk.png"));
            Irkutskayaobl.AddCities(new City("Саянск", "sayansk.png"));
            Irkutskayaobl.AddCities(new City("Свирск", "svirsk.png"));
            Irkutskayaobl.AddCities(new City("Слюдянка", "slyudyanka.png"));
            Irkutskayaobl.AddCities(new City("Тайшет", "tayshet.png"));
            Irkutskayaobl.AddCities(new City("Тулун", "tulun.png"));
            Irkutskayaobl.AddCities(new City("Усолье-Сибирское", "usoliesibirskoe.png"));
            Irkutskayaobl.AddCities(new City("Усть-Илимск", "ustilimsk.png"));
            Irkutskayaobl.AddCities(new City("Усть-Кут", "ustkut.png"));
            Irkutskayaobl.AddCities(new City("Черемхово", "cheremkhovo.png"));
            Irkutskayaobl.AddCities(new City("Шелехов", "shelehov.png"));
          
            Irkutskayaobl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(Irkutskayaobl);

        }
    }
}
