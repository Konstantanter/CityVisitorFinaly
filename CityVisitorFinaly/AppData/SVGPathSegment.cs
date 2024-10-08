using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData
{
    internal class SVGPathSegment
    {
        public char mCommand;
        public List<float> mCoordinates;

        public SVGPathSegment(char command, List<float> coordinates)
        {
            this.mCommand = command;
            this.mCoordinates = coordinates;
        }

        public char getCommand()
        {
            return this.mCommand;
        }

        public void setCommand(char command)
        {
            this.mCommand = command;
        }

        public List<float> getCoordinates()
        {
            return this.mCoordinates;
        }

        public void setCoordinates(List<float> coordinates)
        {
            this.mCoordinates = coordinates;
        }



    }
}
