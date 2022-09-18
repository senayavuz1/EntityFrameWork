using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirst.Entities
{
    public class Adres:BaseEntity
    {
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }

        [MaxLength(100)]
        public string Cadde { get; set; }

        [MaxLength(100)]
        public string Sokak { get; set; }

        [MaxLength(50)]
        public string KapiNo { get; set; }

    }
}