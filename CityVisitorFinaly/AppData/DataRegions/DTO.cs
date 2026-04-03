using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData.DataRegions
{
    public class CityDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class RegionDto
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string MapId { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}
