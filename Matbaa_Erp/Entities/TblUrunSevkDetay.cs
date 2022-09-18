using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunSevkDetay
    {
        public long Urunsevkdetayid { get; set; }
        public int Aracid { get; set; }
        public string Plaka { get; set; }
        public DateTime? Sevktarih { get; set; }
        public double Toplamagirlik { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
