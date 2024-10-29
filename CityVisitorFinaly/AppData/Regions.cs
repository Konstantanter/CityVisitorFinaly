using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CityVisitorFinaly.AppData
{
    /// <summary>
    /// Регион Российской Федерации
    /// </summary>
    public class Regions : INotifyPropertyChanged
    {
        /// <summary>
        /// ИД Региона
        /// </summary>
        public int IdRegion { get; set; }
        /// <summary>
        /// Конструкция для базы данных
        /// </summary>
        public static int Id { get; set; }
        /// <summary>
        /// Имя региона 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ИД на карте для зарисовки
        /// </summary>
        public string IdRegionsMaps { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public ImageSource Image { get; set; }
        /// <summary>
        /// Путь к изображению
        /// </summary>
        public string PathImage { get; set; }
        /// <summary>
        /// Состояние региона
        /// </summary>
        public string StateReg { get; set; } = State.NotVisited.ToString();
        /// <summary>
        /// Список городов региона
        /// </summary>
        public ObservableCollection<City> ListCities { get; set; } = new ObservableCollection<City>();
        /// <summary>
        /// Отрисовка процента посещения
        /// </summary>
        /// <param name="res"></param>
        public void SetVisitPercentage(double res)
        {
            VisitPercentage = string.Format("{0} %", Math.Round(res, 2));

            RegionsDB reg1 = new RegionsDB(this);
            //обновляем данные в базе данных
            App.Db.UpdateRegion(reg1);
        }
        /// <summary>
        /// Процесс регистрации города в регионе
        /// </summary>
        /// <param name="city"></param>
        public void AddCities(City city)
        {
            city.IdRegionsMaps = IdRegionsMaps;
            city.Regionid = IdRegion;
            ListCities.Add(city);
        }
        /// <summary>
        /// Функция сохранения изменений в регионе
        /// </summary>
        public void SaveReg(City refreshCity)
        {

            
            ////проверяем наличие посещенных городов
            //if (cur != 0)
            //{
            //    //Закрашиваем регион на карте цветом (как посещенный)
            //    PaintRegionOnMaps(IdRegionsMaps, Color.Green);
            //}
            //else
            //{
            //    //Закрашиваем как непосещенный
            //    PaintRegionOnMaps(IdRegionsMaps, Color.White);
            //}
            //создаем экземпляр класса для хранения метаданных в базе данных



            RegionsDB reg1 = new RegionsDB(this);
            //обновляем данные в базе данных
            App.Db.UpdateRegion(reg1);


            //делаем обновление для всех городов региона


            CityDB city1 = new CityDB(refreshCity, reg1.Id);
            city1.SaveCity();

        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="name">Имя региона</param>
        /// <param name="pathImg">путь к изображению (герб)</param>
        public Regions(string name, string pathImg)
        {
            Name = name;
            PathImage = pathImg;
            Image = pathImg;
            Id++;
            IdRegion = Id;
        }

        public void AddCities(List<CityDB> cities)
        {
            foreach (CityDB CityDB in cities)
            {
                ListCities.Add(new City(CityDB));
            }
        }
        public Regions(RegionsDB reg)
        {
            IdRegion = reg.Id;
            Name = reg.Name;
            PathImage = reg.PathImage;
            Image = reg.PathImage;
            StateReg = reg.StateReg;
            VisitPercentage = reg.VisitPercentage;
            IdRegionsMaps = reg.IdRegionsMaps;

        }
        public Regions() { }
        public string ShowInfo()
        {
            int CountCities = ListCities.Count;
            string info = $"Имя региона {Name}\nОбщее количество городов: {CountCities}\n";
            int FullCities = ListCities.Where(a => a.State == State.Visited).Count();
            int TransitCities = ListCities.Where(a => a.State == State.VisitedTransit).Count();
            int NotCities = CountCities - FullCities - TransitCities;

            info += $"Посещенные города: {FullCities}\nГорода посещеннные проездом: {TransitCities}\nНе посещенные города: {NotCities}";
            return info;

        }
        private string _visitPercentage { get; set; }
        /// <summary>
        /// Процент посещения
        /// </summary>
        public string VisitPercentage
        {
            get => _visitPercentage;
            set
            {
                _visitPercentage = value;
                OnPropertyChanged("VisitPercentage");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
