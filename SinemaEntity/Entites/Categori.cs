using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaEntity.Entites
{
    public class Categori:BaseEntity
    {
        public string KategoriAdi { get; set; }
        public IList<Film> Filmler { get; set; }
    }
}
