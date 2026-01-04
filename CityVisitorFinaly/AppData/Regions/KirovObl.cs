using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Кировской области
        /// </summary>
        public void KirovObl()
        {
            Regions KirovObl = new Regions("Кировская область", "kirovobl.png")
            {
                IdRegionsMaps = "path114"
            };
            KirovObl.AddCities(new City("Белая Холуница", "belayaholunitsa.png"));
            KirovObl.AddCities(new City("Вятские Поляны", "vyatskiepolyany.png"));
            KirovObl.AddCities(new City("Зуевка", "zuevka.png"));
            KirovObl.AddCities(new City("Киров", "kirov_kirobobl.png"));
            KirovObl.AddCities(new City("Кирово-Чепецк", "kirovochepetsk.png"));
            KirovObl.AddCities(new City("Кирс", "kirs.png"));
            KirovObl.AddCities(new City("Котельнич", "kotelnich.png"));
            KirovObl.AddCities(new City("Луза", "luza.png"));
            KirovObl.AddCities(new City("Малмыж", "malmyzh.png"));
            KirovObl.AddCities(new City("Мураши", "murashy.png"));
            KirovObl.AddCities(new City("Нолинск", "nolinsk.png"));
            KirovObl.AddCities(new City("Омутнинск", "omutninsk.png"));
            KirovObl.AddCities(new City("Орлов", "stroitel.png"));
            KirovObl.AddCities(new City("Слободской", "slobodskoy.png"));
            KirovObl.AddCities(new City("Советск", "sovetsk_kirobobl.png"));
            KirovObl.AddCities(new City("Сосновка", "sosnovk.png"));
            KirovObl.AddCities(new City("Уржум", "urzhum.png"));
            KirovObl.AddCities(new City("Яранск", "yaransk.png"));
            KirovObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KirovObl);
        }
    }
}
