using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Челябинской области
        /// </summary>
        public void ChelyabinskayaObl()
        {
            Regions ChelyabinskayaObl = new Regions("Челябинская область", "chelyabinskoblast.png")
            {
                IdRegionsMaps = "path174"
            };

            ChelyabinskayaObl.AddCities(new City("Аша", "asha.png"));
            ChelyabinskayaObl.AddCities(new City("Бакал", "bakal.png"));
            ChelyabinskayaObl.AddCities(new City("Верхнеуральск", "verkhneuralsk.png"));
            ChelyabinskayaObl.AddCities(new City("Верхний Уфалей", "verkhnyufaley.png"));
            ChelyabinskayaObl.AddCities(new City("Еманжелинск", "emanzhelinsk.png"));
            ChelyabinskayaObl.AddCities(new City("Златоуст", "zlatoust.png"));
            ChelyabinskayaObl.AddCities(new City("Карабаш", "karabash.png"));
            ChelyabinskayaObl.AddCities(new City("Карталы", "kartaly.png"));
            ChelyabinskayaObl.AddCities(new City("Касли", "kasli.png"));
            ChelyabinskayaObl.AddCities(new City("Катав-Ивановск", "katavIvanovsk.png"));
            ChelyabinskayaObl.AddCities(new City("Копейск", "kopeysk.png"));
            ChelyabinskayaObl.AddCities(new City("Коркино", "korkino.png"));
            ChelyabinskayaObl.AddCities(new City("Куса", "kusa.png"));
            ChelyabinskayaObl.AddCities(new City("Кыштым", "kyshtym.png"));
            ChelyabinskayaObl.AddCities(new City("Магнитогорск", "magnitogorsk.png"));
            ChelyabinskayaObl.AddCities(new City("Миасс", "miass.png"));
            ChelyabinskayaObl.AddCities(new City("Магас", "Magas.png"));
            ChelyabinskayaObl.AddCities(new City("Миньяр", "minyar.png"));
            ChelyabinskayaObl.AddCities(new City("Нязепетровск", "nyazepetrovsk.png"));
            ChelyabinskayaObl.AddCities(new City("Озёрск", "ozyorsk.png"));
            ChelyabinskayaObl.AddCities(new City("Пласт", "plast.png"));
            ChelyabinskayaObl.AddCities(new City("Сатка", "satka.png"));
            ChelyabinskayaObl.AddCities(new City("Сим", "sim.png"));
            ChelyabinskayaObl.AddCities(new City("Снежинск", "snezhinsk.png"));
            ChelyabinskayaObl.AddCities(new City("Трёхгорный", "tryokhgorny.png"));
            ChelyabinskayaObl.AddCities(new City("Троицк", "troitsk.png"));
            ChelyabinskayaObl.AddCities(new City("Усть-Катав", "ustkatav.png"));
            ChelyabinskayaObl.AddCities(new City("Чебаркуль", "chebarkul.png"));
            ChelyabinskayaObl.AddCities(new City("Челябинск", "chelyabinsk.png"));
            ChelyabinskayaObl.AddCities(new City("Южноуральск", "yuzhnouralsk.png"));
            ChelyabinskayaObl.AddCities(new City("Юрюзань", "yuryuzan.png"));
           
            AddRegToDB(ChelyabinskayaObl);
        }
    }
}
