using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblVardiyaHareket
    {
        public int Vardiyano { get; set; }
        public int Vardiyaaltno { get; set; }
        public string Urunkod { get; set; }
        public bool Hammadde { get; set; }
        public int Hareketno { get; set; }
        public double Harcananalan { get; set; }
        public double Firealan { get; set; }
        public double Harcananalan2 { get; set; }
    }
}
