using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Пензенской области
        /// </summary>
        public void PermKrai()
        {
            Regions PermKrai = new Regions("Пермский край", "permkrai.png")
            {
                IdRegionsMaps = "path76"
            };
            PermKrai.AddCities(new City("Александровск", "aleksandrovsky.png"));
            PermKrai.AddCities(new City("Березники", "berezniki.png"));
            PermKrai.AddCities(new City("Верещегино", "vereshchagino.png"));
            PermKrai.AddCities(new City("Горнозаводск", "gornozavodzk.png"));
            PermKrai.AddCities(new City("Гремячинск", "gremyachinsk.png"));
            PermKrai.AddCities(new City("Губаха", "gubaha.png"));
            PermKrai.AddCities(new City("Добрянка", "dobryanka.png"));
            PermKrai.AddCities(new City("Кизел", "kizel.png"));
            PermKrai.AddCities(new City("Красновишерск", "krasnovishersk.png"));
            PermKrai.AddCities(new City("Краснокамск", "krasnokamsk.png"));
            PermKrai.AddCities(new City("Кудымкар", "kudymkar.png"));
            PermKrai.AddCities(new City("Кунгур", "kungur.png"));
            PermKrai.AddCities(new City("Лысьва", "lysva.png"));
            PermKrai.AddCities(new City("Нытва", "nytva.png"));
            PermKrai.AddCities(new City("Оса", "osa.png"));
            PermKrai.AddCities(new City("Оханск", "ohansk.png"));
            PermKrai.AddCities(new City("Очёр", "ochyor.png"));
            PermKrai.AddCities(new City("Пермь", "perm.png"));
            PermKrai.AddCities(new City("Соликамск", "solikamsk.png"));
            PermKrai.AddCities(new City("Усолье", "usolye.png"));
            PermKrai.AddCities(new City("Чайковский", "chaykovskii.png"));
            PermKrai.AddCities(new City("Чердынь", "cherdyn.png"));
            PermKrai.AddCities(new City("Чёрмоз", "chermoz.png"));
            PermKrai.AddCities(new City("Чернушка", "chernyshka.png"));
            PermKrai.AddCities(new City("Чусовой", "chusovskoy.png"));
   
            PermKrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(PermKrai);
        }
    }
}
