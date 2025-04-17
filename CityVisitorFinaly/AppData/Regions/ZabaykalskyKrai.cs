using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ярославской области
        /// </summary>
        public void ZabaykalskyKrai()
        {
            Regions ZabaykalskyKrai = new Regions("Забайкальский край", "zabaykalsky.png")
            {
                IdRegionsMaps = "path68"
            };

            ZabaykalskyKrai.AddCities(new City("Балей", "baley.png"));
            ZabaykalskyKrai.AddCities(new City("Борзя", "borzya.png"));
            ZabaykalskyKrai.AddCities(new City("Краснокаменск", "krasnokamensk.png"));
            ZabaykalskyKrai.AddCities(new City("Могоча", "mogocha.png"));
            ZabaykalskyKrai.AddCities(new City("Нерчинск", "nerchinskoe.png"));
            ZabaykalskyKrai.AddCities(new City("Петровск-Забайкальский", "petrovskzabaikalsky.png"));
            ZabaykalskyKrai.AddCities(new City("Сретенск", "sretensk.png"));
            ZabaykalskyKrai.AddCities(new City("Хилок", "hilok.png"));
            ZabaykalskyKrai.AddCities(new City("Чита", "chita.png"));
            ZabaykalskyKrai.AddCities(new City("Шилка", "shilka.png"));
            ZabaykalskyKrai.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(ZabaykalskyKrai);
        }
    }
}
