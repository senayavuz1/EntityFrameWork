using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunAgirlik
    {
        public string Urunkod { get; set; }
        public double Urunmiktar { get; set; }
        public string Birimkod { get; set; }
        public double Tekebadboy { get; set; }
        public double Tekebaden { get; set; }
        public double Tekebadyukseklik { get; set; }
        public double Urunagirlik { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
