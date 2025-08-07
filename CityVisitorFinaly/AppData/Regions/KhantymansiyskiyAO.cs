using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ханты-Мансийский АО - Югра
        /// </summary>
        public void KhantymansiyskiyAO()
        {
            Regions KhantymansiyskiyAO = new Regions("Ханты-Мансийский АО - Югра", "khantymansia.png")
            {
                IdRegionsMaps = "path357"
            };

            KhantymansiyskiyAO.AddCities(new City("Белоярский", "beloyarsky.png"));
            KhantymansiyskiyAO.AddCities(new City("Когалым", "kogalym.png"));
            KhantymansiyskiyAO.AddCities(new City("Лангепас", "langepas.png"));
            KhantymansiyskiyAO.AddCities(new City("Лянтор", "lyantor.png"));
            KhantymansiyskiyAO.AddCities(new City("Мегион", "megion.png"));
            KhantymansiyskiyAO.AddCities(new City("Нефтеюганск", "nefteyugansk.png"));
            KhantymansiyskiyAO.AddCities(new City("Нижневартовск", "nizhnevartovsk.png"));
            KhantymansiyskiyAO.AddCities(new City("Нягань", "nyagan.png"));
            KhantymansiyskiyAO.AddCities(new City("Покачи", "pokachi.png"));
            KhantymansiyskiyAO.AddCities(new City("Пыть-Ях", "pytyakh.png"));
            KhantymansiyskiyAO.AddCities(new City("Радужный", "raduzhnyj.png"));
            KhantymansiyskiyAO.AddCities(new City("Советский", "sovetsky.png"));
            KhantymansiyskiyAO.AddCities(new City("Сургут", "surgut.png"));
            KhantymansiyskiyAO.AddCities(new City("Урай", "uray.png"));
            KhantymansiyskiyAO.AddCities(new City("Ханты-Мансийск", "khantymansiysk.png"));
            KhantymansiyskiyAO.AddCities(new City("Югорск", "yugorsk.png"));
            KhantymansiyskiyAO.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(KhantymansiyskiyAO);
        }
    }
}
