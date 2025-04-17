using SkiaSharp;
using SQLite;

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
        /// Состояние региона
        /// </summary>
        public string StateReg { get; set; } = State.NotVisited.ToString();

        /// <summary>
        /// Статус региона на карте (добавлен/не добавлен)
        /// </summary>
        public string Append_Reg { get; set; } = AppendReg.RegNoAppend.ToString();

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
            StateReg = reg.StateReg.ToString();
            PathImage = reg.PathImage;
            VisitPercentage = reg.VisitPercentage;
            Append_Reg = reg.Append_Reg.ToString();
        }
    }
}
