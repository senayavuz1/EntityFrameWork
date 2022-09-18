using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaEntity.Entites
{
    public class Gosterim
    {
        #region Database'deki Kolonlar
        
        public int SalonId { get; set; }
        
        public int WeekId { get; set; }
        public int SeansId { get; set; }
        public int FilmId { get; set; }

        #endregion


        #region Diger Tablolarla iliskileri-Navigation Property
        public Seans Seanslar { get; set; }
        
        public Week Haftalar { get; set; }
        public Salon Salonlar { get; set; }
        public Film Filmler { get; set; } 
        #endregion
    }
}
