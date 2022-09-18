using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTeklifGonder
    {
        public long Kodu { get; set; }
        public int Gonderno { get; set; }
        public string Gonderkodu { get; set; }
        public DateTime Gondertarih { get; set; }
        public string Sonucteklifkod { get; set; }
        public string Personelkodu { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
