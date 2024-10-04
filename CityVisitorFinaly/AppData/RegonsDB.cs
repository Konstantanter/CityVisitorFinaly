using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.AppData
{
    public class RegionsDB
    {
        /// <summary>
        /// ИД регоина
        /// </summary>
        [PrimaryKey]
        public int Id { get; set; }
        /// <summary>
        /// Имя региона 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ИД на карте
        /// </summary>
        public string IdRegionsMaps { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string PathImage { get; set; }
        /// <summary>
        /// Процент посещения
        /// </summary>
        public string VisitPercentage { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public RegionsDB() { }
        /// <summary>
        /// Конструктор с пааметрами
        /// </summary>
        /// <param name="reg">Регион</param>
        public RegionsDB(Regions reg)
        {
            Id = reg.IdRegion;
            IdRegionsMaps = reg.IdRegionsMaps;
            Name = reg.Name;
            PathImage = reg.PathImage;
            VisitPercentage = reg.VisitPercentage;
        }
    }
}
