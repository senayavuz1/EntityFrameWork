using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunSevk
    {
        public long Urunsevkid { get; set; }
        public string Stokkod { get; set; }
        public long Siparisno { get; set; }
        public string Urunkod { get; set; }
        public short Urunno { get; set; }
        public string Setmi { get; set; }
        public string Takimtek { get; set; }
        public string Firmakod { get; set; }
        public string Subekod { get; set; }
        public double Miktar { get; set; }
        public string Sevkedildi { get; set; }
        public DateTime? Sevktaleptarihi { get; set; }
        public int Koliadet { get; set; }
        public int Ruloadet { get; set; }
        public string Urunadet { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Birimkod { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
