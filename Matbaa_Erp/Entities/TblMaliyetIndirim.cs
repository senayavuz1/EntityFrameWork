using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetIndirim
    {
        public int Indirimno { get; set; }
        public int Maliyetkodu { get; set; }
        public short Yuzdeindirim { get; set; }
        public string Sebep { get; set; }
        public bool? Iptal { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
