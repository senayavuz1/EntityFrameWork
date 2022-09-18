using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirst.Entities
{
    public class Sehir:BaseEntity
    {
        [MaxLength(30)]
        public string SehirAdi { get; set; }
        public List<Ilce> Ilce { get; set; }

    }
}