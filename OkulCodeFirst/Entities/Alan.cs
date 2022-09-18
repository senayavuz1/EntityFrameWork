using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirst.Entities
{
    public class Alan:BaseEntity
    {
        [MaxLength(50)]
        public string AlanAdi { get; set; }

        public List<Sinif> Siniflar { get; set; }

    }
}