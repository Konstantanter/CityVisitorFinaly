using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Приморского края
        /// </summary>
        public void PrimorskyiKrai()
        {
            Regions PrimorskyiKrai = new Regions("Приморский край", "primorskykrai.png")
            {
                IdRegionsMaps = "path78"
            };

            PrimorskyiKrai.AddCities(new City("Арсеньев", "arseniev.png"));
            PrimorskyiKrai.AddCities(new City("Артём", "artyom.png"));
            PrimorskyiKrai.AddCities(new City("Большой Камень", "bolshoykamen.png"));
            PrimorskyiKrai.AddCities(new City("Владивосток", "vladivostok.png"));
            PrimorskyiKrai.AddCities(new City("Дальнегорск", "dalnegorsk.png"));
            PrimorskyiKrai.AddCities(new City("Даальнереченск", "makarov.png"));
            PrimorskyiKrai.AddCities(new City("Лесозаводск", "lesozavodsk.png"));
            PrimorskyiKrai.AddCities(new City("Находка", "nakhodka.png"));
            PrimorskyiKrai.AddCities(new City("Партизанск", "partizansk.png"));
            PrimorskyiKrai.AddCities(new City("Спасскк-Дальний", "spasskdalniy.png"));
            PrimorskyiKrai.AddCities(new City("Уссурийск", "ussuriysk.png"));
            PrimorskyiKrai.AddCities(new City("Фокино", "fokino_primorskiy.png"));


            PrimorskyiKrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(PrimorskyiKrai);
        }
    }
}
