using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDilim
    {
        public string Urunkod { get; set; }
        public string Stokkod { get; set; }
        public string Stokno { get; set; }
        public string Dilmeno { get; set; }
        public double Eskimiktar1 { get; set; }
        public double? Eskimiktar2 { get; set; }
        public double Miktar1 { get; set; }
        public double? Miktar2 { get; set; }
        public string Birimkod { get; set; }
        public byte Seviye { get; set; }
        public int Dilmekod { get; set; }
        public string Gideceksiparisno { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
