using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaEntity.Entites
{
    public class Salon:BaseEntity
    {
        public string SalonAdi { get; set; }
        public short Kapasite { get; set; }
    }
}
