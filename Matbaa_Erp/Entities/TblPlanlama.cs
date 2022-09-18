using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPlanlama
    {
        public DateTime? Baslamatarih { get; set; }
        public string Baslamasaat { get; set; }
        public DateTime? Bitistarih { get; set; }
        public string Bitissaat { get; set; }
        public string Siparisno { get; set; }
        public short? Siralama { get; set; }
        public double? Sure { get; set; }
        public string Makinakodu { get; set; }
        public string Islemkod { get; set; }
    }
}
