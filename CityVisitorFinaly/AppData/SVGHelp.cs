using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData
{
    internal class SVGHelp
    {
        /// <summary>
        /// Id региона
        /// </summary>
        public string IdReg { get; set; }
        /// <summary>
        /// Координаты для отрисовки регоина
        /// </summary>
        public SkiaSharp.SKPath SKPath { get; set; }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="idreg"></param>
        /// <param name="skpath"></param>
        public SVGHelp(string idreg, SkiaSharp.SKPath skpath)
        {
            IdReg = idreg;
            SKPath = skpath;
        }
    }
}
