using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Саратовской области
        /// </summary>
        public void SaratovObl()
        {
            Regions SaratovObl = new Regions("Саратовская область", "saratovobl.png")
            {
                IdRegionsMaps = "path154"
            };
            SaratovObl.AddCities(new City("Аркадак", "arkadak.png"));
            SaratovObl.AddCities(new City("Аткарск", "atkarsk.png"));
            SaratovObl.AddCities(new City("Балаково", "balakovo.png"));
            SaratovObl.AddCities(new City("Балашов", "balashov.png"));
            SaratovObl.AddCities(new City("Вольск", "volsk.png"));
            SaratovObl.AddCities(new City("Ершов", "ershov.png"));
            SaratovObl.AddCities(new City("Калининск", "kalininsk.png"));
            SaratovObl.AddCities(new City("Красноармейск", "krasnoarmeysksaratov.png"));
            SaratovObl.AddCities(new City("Красный Кут", "krasnyikyt.png"));
            SaratovObl.AddCities(new City("Маркс", "marks.png"));
            SaratovObl.AddCities(new City("Новоузенск", "novouzensk.png"));
            SaratovObl.AddCities(new City("Петровск", "petrovsk.png"));
            SaratovObl.AddCities(new City("Пугачёв", "pugachyov.png"));
            SaratovObl.AddCities(new City("Ртищево", "rtishchevo.png"));
            SaratovObl.AddCities(new City("Саратов", "saratov.png"));
            SaratovObl.AddCities(new City("Хвалынск", "khvalynsk.png"));
            SaratovObl.AddCities(new City("Шиханы", "shikhany.png"));
            SaratovObl.AddCities(new City("Энгельс", "engels.png"));
            
            SaratovObl.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(SaratovObl);
        }
    }
}
