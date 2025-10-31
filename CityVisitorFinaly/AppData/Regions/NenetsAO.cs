using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Ненецкого АО
        /// </summary>
        public void NenetsAO()
        {
            Regions NenetsAO = new Regions("Ненецкий АО", "nenetsautonomousokrug.png")
            {
                IdRegionsMaps = "path355"
            };
            NenetsAO.AddCities(new City("Нарьян-Мар", "naryanmar.png"));
            NenetsAO.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(NenetsAO);
        }
    }
}
