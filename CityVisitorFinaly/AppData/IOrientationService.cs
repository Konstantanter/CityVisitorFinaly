using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace CityVisitorFinaly.Services
    {
        public interface IOrientationService
        {
            void SetLandscape();
            void SetPortrait();
            void SetUnspecified();
        }
    }

