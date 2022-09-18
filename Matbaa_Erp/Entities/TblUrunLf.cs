using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunLf
    {
        public long Urunlfid { get; set; }
        public string Urunkod { get; set; }
        public double Lf { get; set; }
        public double Aramesafe { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
