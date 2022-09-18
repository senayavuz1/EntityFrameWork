using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunKk
    {
        public string Urunkod { get; set; }
        public short Sira { get; set; }
        public short Iccap { get; set; }
        public short Discap { get; set; }
        public int Bobindeadet { get; set; }
        public string Bobindebirim { get; set; }
        public string Akisyonu { get; set; }
        public short Musteriyyadet { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
