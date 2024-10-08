using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData
{
    internal class SVGHelp
    {
        public string IdReg { get; set; }
        public SkiaSharp.SKPath SKPath { get; set; }

        public SVGHelp(string idreg, SkiaSharp.SKPath skpath)
        {
            IdReg = idreg;
            SKPath = skpath;
        }
    }
}
