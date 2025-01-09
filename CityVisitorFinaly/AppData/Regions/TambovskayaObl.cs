using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Тамбовской области
        /// </summary>
        public void TambovskayaObl()
        {
            Regions TambovskayaObl = new Regions("Тамбовская область", "tambovoblast.png")
            {
                IdRegionsMaps = "path162"
            };
            TambovskayaObl.AddCities(new City("Жердевка", "zherdevka.png"));
            TambovskayaObl.AddCities(new City("Кирсанов", "kirsanov.png"));
            TambovskayaObl.AddCities(new City("Котовск", "kotovsk.png"));
            TambovskayaObl.AddCities(new City("Мичуринск", "michurinsk.png"));
            TambovskayaObl.AddCities(new City("Моршанск", "morshansk.png"));
            TambovskayaObl.AddCities(new City("Рассказово", "rasskazovo.png"));
            TambovskayaObl.AddCities(new City("Тамбов", "tambov.png"));
            TambovskayaObl.AddCities(new City("Уварово", "uvarovo.png"));
    
        
            AddRegToDB(TambovskayaObl);
        }
    }
}
