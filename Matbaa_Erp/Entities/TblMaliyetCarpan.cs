using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetCarpan
    {
        public int Maliyetkodu { get; set; }
        public double Carpan { get; set; }
        public double Adet { get; set; }
        public int? Ek { get; set; }
        public double Minadet { get; set; }
        public double Maxadet { get; set; }
        public double Mlzfiyat { get; set; }
        public double Fiyat { get; set; }
        public double Fiyatalan { get; set; }
        public double Fiyatagirlik { get; set; }
        public double Fiyatuzunluk { get; set; }
        public double? Ttutar { get; set; }
    }
}
