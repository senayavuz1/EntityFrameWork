using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCodeFirst.Entities
{
    public class Kisi:BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string Gsm { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }

        public List<Adres> Adresler{ get; set; }
    }
}
