using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblRandevu
    {
        public long Randevuno { get; set; }
        public long Gorid { get; set; }
        public string Firmakod { get; set; }
        public DateTime Randevutarihi { get; set; }
        public string BasSaat { get; set; }
        public string Personelkodu { get; set; }
        public string Sure { get; set; }
        public string RandevuSaat { get; set; }
        public int Gorusmeno { get; set; }
        public string Bilgi { get; set; }
        public string Gorusmetipno { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
