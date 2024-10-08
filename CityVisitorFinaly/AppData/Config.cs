using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData
{
    /// <summary>
    /// Класс лобального конфига для настройки приложения
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Цвет полноценного посещения
        /// </summary>
        public static SKColor ColorFullVisit { get; set; }
        /// <summary>
        /// Цвет посещения регионом проездом
        /// </summary>
        public static SKColor ColorPassingVisit { get; set; }
        /// <summary>
        /// Отображать регионы проездом
        /// </summary>
        public static bool VisiblePassing { get; set; }
        /// <summary>
        /// Ширина границы
        /// </summary>
        public static int StrokeWidth { get; set; }
        /// <summary>
        /// Цвет обводки
        /// </summary>
        public static SKColor OutlineColor { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Config()
        {

            //Задаем параметры по умолчанию
            ColorFullVisit = new SKColor(46, 136, 87);
            ColorPassingVisit = SKColors.Yellow;
            VisiblePassing = true;
            OutlineColor = SKColors.Black;
            StrokeWidth = 1;
        }
    }
}
