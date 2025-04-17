using System.ComponentModel;


namespace CityVisitorFinaly.AppData
{
    /// <summary>
    /// Город региона
    /// </summary>
    public class City : INotifyPropertyChanged
    {
        /// <summary>
        /// Ид города
        /// </summary>
        public int IdCity { get; set; }
        /// <summary>
        /// Автоинкремент (нужно для нумерации городов в базе данных)
        /// </summary>
        public static int Id { get; set; } = 0;
        /// <summary>
        /// ИД Региона
        /// </summary>
        public int Regionid { get; set; }
        /// <summary>
        /// Приватная переменная, харнящая наличие магнитика из города
        /// </summary>
        private bool _magned;
        /// <summary>
        /// Есть ли магнит или нет
        /// </summary>
        public bool Magned
        {
            get => _magned;
            set { _magned = value; OnPropertyChanged("Magned"); }
        }
        /// <summary>
        /// Приватная переменная для даны посещения города
        /// </summary>
        private string _dataVisited;
        /// <summary>
        /// Дата посещения города
        /// </summary>
        public string DataVisited
        {
            get => _dataVisited;
            set { _dataVisited = value; OnPropertyChanged("DataVisited"); }
        }
        /// <summary>
        /// Нужно для закраски карты
        /// </summary>
        public string IdRegionsMaps { get; set; }
        /// <summary>
        /// Имя города
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public ImageSource Image { get; set; }
        /// <summary>
        /// Чтобы не хранить целое изображение в базе, мы будем хранить путь
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// Состояние города
        /// </summary>
        private State _state;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public City()
        {
            _isVisited = false;
            _state = State.NotVisited;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя города</param>
        /// <param name="img">Путь к изображению</param>
        public City(string name, string img)
        {
            Name = name;
            Image = img;
            ImagePath = img;
            _isVisited = false;
            _state = State.NotVisited;
            Id++;
            IdCity = Id;
            _magned = false;
        }
        /// <summary>
        /// Конструктор для преобразования городадля хранения его в базе данных
        /// </summary>
        /// <param name="city">Класс для хранения в базе данных</param>
        public City(CityDB city)
        {
            IdCity = city.Id;
            Name = city.Name;
            Regionid = city.Regionid;
            Image = city.ImagePath;
            ImagePath = city.ImagePath;
            State = city.StateCity;
            IdRegionsMaps = city.IdRegionsMaps;
            Magned = city.Magned;
            DataVisited = city.DataVisited;
        }
        /// <summary>
        /// Посещен ли город или нет (приватная)
        /// </summary>
        private bool _isVisited;
        /// <summary>
        /// Состояние города
        /// </summary>
        public State State
        {
            get => _state;
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged(nameof(State)); // Используйте nameof для обеспечения безопасности
                }
            }
        }
        /// <summary>
        /// Посещение города
        /// </summary>
        public bool IsVisited
        {
            get => _isVisited;
            set
            {
                _isVisited = value;
                OnPropertyChanged("IsVisited");
            }
        }
        /// <summary>
        /// Событие изменения данных
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
    /// <summary>
    /// Статус города
    /// </summary>
    public enum State
    {
        /// <summary>
        /// Посещен полноценно
        /// </summary>
        Visited,
        /// <summary>
        /// Посещен проездом
        /// </summary>
        VisitedTransit,
        /// <summary>
        /// Не посещен
        /// </summary>
        NotVisited
    }
    /// <summary>
    /// Статус региона по добавлению
    /// </summary>
    public enum AppendReg
    {
        //Добавлен
        RegAppend,
        //Не добавлен
        RegNoAppend
    }
}
