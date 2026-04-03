using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {

        /// <summary>
        /// Инициализация городов (в случае их отсутствия)
        /// </summary>
       
        public void AddRegToDB(RegionsRF region)
        {
            RegionsDB reg1 = new RegionsDB(region);
            App.Db.InsertRegion(reg1);
            AddListCitiesToDB(region.ListCities, region.IdRegion);
        }
        public void AddListCitiesToDB(ObservableCollection<City> CityList, int regionId)
        {
            foreach (City city in CityList)
            {
                CityDB CityDB = new CityDB(city, regionId);
                CityDB.InsertCity();
            }
        }
    }
}
