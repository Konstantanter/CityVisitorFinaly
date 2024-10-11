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
    static public class Config
    {
        /// <summary>
        /// Цвет полноценного посещения
        /// </summary>
        public static SKColor ColorFullVisit { get; set; } = new SKColor(46, 136, 87);
        /// <summary>
        /// Цвет посещения регионом проездом
        /// </summary>
        public static SKColor ColorPassingVisit { get; set; } = SKColors.Yellow;
        /// <summary>
        /// Отображать регионы проездом
        /// </summary>
        public static bool VisiblePassing { get; set; } = true;
        /// <summary>
        /// Ширина границы
        /// </summary>
        public static int StrokeWidth { get; set; } = 1;
        /// <summary>
        /// Цвет обводки
        /// </summary>
        public static SKColor OutlineColor { get; set; } = SKColors.Black;
        
    }
}
