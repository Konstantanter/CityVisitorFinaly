using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {
        /// <summary>
        /// Инициализация Свердловской области
        /// </summary>
        public void SverdlovskayaObl()
        {
            Regions SverdlovskayaObl = new Regions("Свердловская область", "sverdlovskoblast.png")
            {
                IdRegionsMaps = "path158"
            };

            SverdlovskayaObl.AddCities(new City("Алапаевск", "alapaevsk.png"));
            SverdlovskayaObl.AddCities(new City("Арамиль", "aramil.png"));
            SverdlovskayaObl.AddCities(new City("Артёмовский", "artemovskiy.png"));
            SverdlovskayaObl.AddCities(new City("Асбест", "asbest.png"));
            SverdlovskayaObl.AddCities(new City("Берёзовский", "berezovsky.png"));
            SverdlovskayaObl.AddCities(new City("Богданович", "bogdanovich.png"));
            SverdlovskayaObl.AddCities(new City("Верхний Тагил", "verhniytagil.png"));
            SverdlovskayaObl.AddCities(new City("Верхняя Пышма", "verkhnyayapyshma.png"));
            SverdlovskayaObl.AddCities(new City("Верхняя Салда", "verkhnyayasalda.png"));
            SverdlovskayaObl.AddCities(new City("Верхняя Тура", "verkhnyayatura.png"));
            SverdlovskayaObl.AddCities(new City("Верхотурье", "verkhotursky.png"));
            SverdlovskayaObl.AddCities(new City("Волчанск", "volchansk.png"));
            SverdlovskayaObl.AddCities(new City("Дегтярск", "degtyarsk.png"));
            SverdlovskayaObl.AddCities(new City("Екатеринбург", "ekaterinburg.png"));
            SverdlovskayaObl.AddCities(new City("Заречный", "zarechnyi.png"));
            SverdlovskayaObl.AddCities(new City("Ивдель", "ivdel.png"));
            SverdlovskayaObl.AddCities(new City("Ирбит", "irbit.png"));
            SverdlovskayaObl.AddCities(new City("Каменск-Уральский", "kamenskuralsky.png"));
            SverdlovskayaObl.AddCities(new City("Камышлов", "kamyshlov.png"));
            SverdlovskayaObl.AddCities(new City("Карпинск", "karpinsk.png"));
            SverdlovskayaObl.AddCities(new City("Качканар", "kachkanar.png"));
            SverdlovskayaObl.AddCities(new City("Каировград", "kirowgrad.png"));
            SverdlovskayaObl.AddCities(new City("Крансотурьинск", "krasnoturinsk.png"));
            SverdlovskayaObl.AddCities(new City("Красноуральск", "krasnouralsk.png"));
            SverdlovskayaObl.AddCities(new City("Красноуфимск", "krasnoufimsk.png"));
            SverdlovskayaObl.AddCities(new City("Кушва", "kushva.png"));
            SverdlovskayaObl.AddCities(new City("Лесной", "lesnoi.png"));
            SverdlovskayaObl.AddCities(new City("Михайловск", "mikhailovsk.png"));
            SverdlovskayaObl.AddCities(new City("Невьянск", "nevyansk.png"));
            SverdlovskayaObl.AddCities(new City("Нижгие Серги", "nizhniesergi.png"));
            SverdlovskayaObl.AddCities(new City("Нижний Тагил", "nizhnytagil.png"));
            SverdlovskayaObl.AddCities(new City("Нижняя Салда", "nizhnyayasalda.png"));
            SverdlovskayaObl.AddCities(new City("Нижняя Тура", "nizhnyayatura.png"));
            SverdlovskayaObl.AddCities(new City("Новая Ляля", "novayalyalya.png"));
            SverdlovskayaObl.AddCities(new City("Новоуральск", "novouralsk.png"));
            SverdlovskayaObl.AddCities(new City("Первоуральск", "pervouralsk.png"));
            SverdlovskayaObl.AddCities(new City("Полевой", "polevskoy.png"));
            SverdlovskayaObl.AddCities(new City("Ревда", "revda.png"));
            SverdlovskayaObl.AddCities(new City("Реж", "rezh.png"));
            SverdlovskayaObl.AddCities(new City("Североуральск", "severouralsk.png"));
            SverdlovskayaObl.AddCities(new City("Серов", "serov.png"));
            SverdlovskayaObl.AddCities(new City("Среднеуральск", "sredneuralsk.png"));
            SverdlovskayaObl.AddCities(new City("Сухой Лог", "sukhoilog.png"));
            SverdlovskayaObl.AddCities(new City("Сысерть", "sysert.png"));
            SverdlovskayaObl.AddCities(new City("Тавда", "tavda.png"));
            SverdlovskayaObl.AddCities(new City("Талица", "talica.png"));
            SverdlovskayaObl.AddCities(new City("Туринск", "turinsk.png"));
         

            AddRegToDB(SverdlovskayaObl);
        }
    }
}
