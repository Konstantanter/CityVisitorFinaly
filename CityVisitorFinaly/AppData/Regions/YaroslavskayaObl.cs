using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ярославской области
        /// </summary>
        public void YaroslavskayaObl()
        {
            Regions YaroslavskayaObl = new Regions("Ярославская область", "yaroslavloblast.png")
            {
                IdRegionsMaps = "path180"
            };

            YaroslavskayaObl.AddCities(new City("Гаврилов-Ям", "gavrilovyam.png"));
            YaroslavskayaObl.AddCities(new City("Данилов", "danilov.png"));
            YaroslavskayaObl.AddCities(new City("Любим", "lyubim.png"));
            YaroslavskayaObl.AddCities(new City("Мышкин", "myshkin.png"));
            YaroslavskayaObl.AddCities(new City("Переславль-Залесский", "pereslavlzalessky.png"));
            YaroslavskayaObl.AddCities(new City("Пошехонье", "poshekhonye.png"));
            YaroslavskayaObl.AddCities(new City("Ростов", "rostov.png"));
            YaroslavskayaObl.AddCities(new City("Рыбинск", "rybinsk.png"));
            YaroslavskayaObl.AddCities(new City("Тутаев", "tutaev.png"));
            YaroslavskayaObl.AddCities(new City("Углич", "uglich.png"));
            YaroslavskayaObl.AddCities(new City("Ярославль", "jaroslavl.png"));
            YaroslavskayaObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(YaroslavskayaObl);
        }
    }
}
