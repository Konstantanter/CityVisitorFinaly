using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Вологодской области
        /// </summary>
        public void VologdaOblast()
        {
            Regions VologdaOblast = new Regions("Вологодская область", "vologdaoblast.png")
            {
                IdRegionsMaps = "path100"
            };
            VologdaOblast.AddCities(new City("Бабаево", "babayevo.png"));
            VologdaOblast.AddCities(new City("Белозерск", "belozersky.png"));
            VologdaOblast.AddCities(new City("Великий Устюг", "velikiiustug.png"));
            VologdaOblast.AddCities(new City("Вологда", "vologda.png"));
            VologdaOblast.AddCities(new City("Вытегра", "vytegra.png"));
            VologdaOblast.AddCities(new City("Грязовец", "gryazovets.png"));
            VologdaOblast.AddCities(new City("Кадников", "kadnikov.png"));
            VologdaOblast.AddCities(new City("Кириллов", "kirillov.png"));
            VologdaOblast.AddCities(new City("Красавино", "krasavino.png"));
            VologdaOblast.AddCities(new City("Никольск", "nikolsk.png"));
            VologdaOblast.AddCities(new City("Сокол", "sokol.png"));
            VologdaOblast.AddCities(new City("Тотьма", "solvychegodsk.png"));
            VologdaOblast.AddCities(new City("Устюжна", "ustyuzhna.png"));
            VologdaOblast.AddCities(new City("Харовск", "harovsky.png"));
            VologdaOblast.AddCities(new City("Череповец", "cherepovezc.png"));
            VologdaOblast.Append_Reg = AppendReg.RegAppend.ToString();
            AddRegToDB(VologdaOblast);
        }
    }
}
