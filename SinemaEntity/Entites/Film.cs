using System.Collections;
using System.Collections.Generic;

namespace SinemaEntity.Entites
{
    public class Film:BaseEntity
    {
        public string FilmAdi { get; set; }
        public string Akilama { get; set; }
        public short Sure { get; set; }

        public IList<Categori> Categoris { get; set; }
    }
}