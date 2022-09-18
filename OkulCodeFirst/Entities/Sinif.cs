using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCodeFirst.Entities
{
    public class Sinif:BaseEntity
    {
        [MaxLength(50)]
        public string SinifAdi { get; set; }
        public short Kapasite { get; set; }

        public Alan Alan { get; set; }
    }
}
