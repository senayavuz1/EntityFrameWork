using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaBakim
    {
        public int Bakimno { get; set; }
        public string Bakimkod { get; set; }
        public string Makinakodu { get; set; }
        public string Talepeden { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Saat { get; set; }
        public DateTime? Baslatarih { get; set; }
        public DateTime? Baslasaat { get; set; }
        public DateTime? Bitistarih { get; set; }
        public DateTime? Bitissaat { get; set; }
        public string Aciliyet { get; set; }
        public string Durumu { get; set; }
        public string Uretimdurdu { get; set; }
        public string Arizatanimi { get; set; }
        public string Bakimtanimi { get; set; }
        public int Hareketno { get; set; }
        public string Sonuc { get; set; }
        public string Bakimiyapan { get; set; }
        public short Sure { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
