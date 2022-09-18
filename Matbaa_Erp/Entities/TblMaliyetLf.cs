using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetLf
    {
        public long Maliyetlfid { get; set; }
        public long Maliyetkodu { get; set; }
        public double Lf { get; set; }
        public double Aramesafe { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
