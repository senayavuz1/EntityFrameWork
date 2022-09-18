using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunSevkDetayAlt
    {
        public long Urunsevkaltid { get; set; }
        public long Urunsevkdetayid { get; set; }
        public long Urunsevkid { get; set; }
        public string Stokkod { get; set; }
        public long Siparisno { get; set; }
        public string Takimtek { get; set; }
        public string Setmi { get; set; }
        public string Firmakod { get; set; }
        public string Subekod { get; set; }
        public string Urunkod { get; set; }
        public short Urunno { get; set; }
        public double Sevkmiktar { get; set; }
        public double Agirlik { get; set; }
        public string Belgekesildi { get; set; }
        public string Belgetipi { get; set; }
        public double Yenifiyat { get; set; }
        public string Birimkod { get; set; }
        public bool Onaysiz { get; set; }
    }
}
