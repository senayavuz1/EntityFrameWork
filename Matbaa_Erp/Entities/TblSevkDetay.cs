using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSevkDetay
    {
        public long Satirdetayid { get; set; }
        public long Satirno { get; set; }
        public int Siparisno { get; set; }
        public long Urunsevkid { get; set; }
        public string Musterisano { get; set; }
        public string Urunkod { get; set; }
        public short Urunno { get; set; }
        public int Sevkiyatno { get; set; }
        public string Stokkod { get; set; }
        public int Koliadet { get; set; }
        public int Ruloadet { get; set; }
        public string Urunadet { get; set; }
        public double Adet { get; set; }
    }
}
