using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Санкт-Петербурга
        /// </summary>
        public void SaintpetersBurg()
        {
            Regions SaintpetersBurg = new Regions("Санкт-Петербург", "saintpetersburgreg.png")
            {
                IdRegionsMaps = "path186"
            };
            SaintpetersBurg.AddCities(new City("Зеленогорск", "zelenogorskpeter.png"));
            SaintpetersBurg.AddCities(new City("Колпино", "kolpino.png"));
            SaintpetersBurg.AddCities(new City("Красное Село", "krasnoeselo.png"));
            SaintpetersBurg.AddCities(new City("Кронштадт", "kronshtadt.png"));
            SaintpetersBurg.AddCities(new City("Ломоносов", "lomonosov.png"));
            SaintpetersBurg.AddCities(new City("Павловск", "pavlovskspb.png"));
            SaintpetersBurg.AddCities(new City("Петергоф", "petergof.png"));
            SaintpetersBurg.AddCities(new City("Пушкин", "pushkin.png"));
            SaintpetersBurg.AddCities(new City("Санкт-Петербург", "saintpetersburg.png"));
            SaintpetersBurg.AddCities(new City("Сестрорецк", "sestroretsk.png"));
           

            SaintpetersBurg.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(SaintpetersBurg);
        }
    }
}
