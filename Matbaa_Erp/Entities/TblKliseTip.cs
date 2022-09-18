using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKliseTip
    {
        public string Klisetipkod { get; set; }
        public string Kodaciklama { get; set; }
        public string Sabagkod { get; set; }
        public float? Fiyatmaliyet { get; set; }
        public string Baskitipkod { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
