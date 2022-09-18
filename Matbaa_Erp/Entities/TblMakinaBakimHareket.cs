using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaBakimHareket
    {
        public int Bakimhareketno { get; set; }
        public int Bakimno { get; set; }
        public string Stokkod { get; set; }
        public string Urunkod { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
    }
}
