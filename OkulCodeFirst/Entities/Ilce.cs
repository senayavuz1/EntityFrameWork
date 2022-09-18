using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirst.Entities
{
    public class Ilce:BaseEntity
    {
        [MaxLength(30)]
        public string IlceAdi { get; set; }
        public Sehir Sehir { get; set; }

    }
}