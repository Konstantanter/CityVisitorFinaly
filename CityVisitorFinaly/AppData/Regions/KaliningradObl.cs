using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Калининградской  области
        /// </summary>
        public void KaliningradObl()
        {
            Regions KaliningradObl = new Regions("Калининградская область", "kaliningradobl.png")
            {
                IdRegionsMaps = "path108"
            };
            KaliningradObl.AddCities(new City("Багратионовск", "bagrationovsk.png"));
            KaliningradObl.AddCities(new City("Балтийск", "baltiysk.png"));
            KaliningradObl.AddCities(new City("Гвардейск", "gvardeisk.png"));
            KaliningradObl.AddCities(new City("Гурьевск", "guryevskkaliningrad.png"));
            KaliningradObl.AddCities(new City("Гусев", "gusiew.png"));
            KaliningradObl.AddCities(new City("Зеленоградск", "zelenogradsk.png"));
            KaliningradObl.AddCities(new City("Калининград", "kaliningrad.png"));
            KaliningradObl.AddCities(new City("Краснознаменск", "krasnoznamenskkaliningrad.png"));
            KaliningradObl.AddCities(new City("Ладушкин", "ladushkin.png"));
            KaliningradObl.AddCities(new City("Мамоново", "mamonovo.png"));
            KaliningradObl.AddCities(new City("Неман", "neman.png"));
            KaliningradObl.AddCities(new City("Нестеров", "nesterov.png"));
            KaliningradObl.AddCities(new City("Озёрск", "ozersk.png"));
            KaliningradObl.AddCities(new City("Пионерский", "pionersky.png"));
            KaliningradObl.AddCities(new City("Полесск", "polessk.png"));
            KaliningradObl.AddCities(new City("Правдинск", "pravdinsk.png"));
            KaliningradObl.AddCities(new City("Приморск", "primorsk.png"));
            KaliningradObl.AddCities(new City("Светлогорск", "svetlogorsk.png"));
            KaliningradObl.AddCities(new City("Светлый", "svetly.png"));
            KaliningradObl.AddCities(new City("Славск", "slavsk.png"));
            KaliningradObl.AddCities(new City("Советск", "sovetskkaliningrad.png"));
            KaliningradObl.AddCities(new City("Черняховск", "chernyakhovsk.png"));

            KaliningradObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KaliningradObl);
        }
    }
}
