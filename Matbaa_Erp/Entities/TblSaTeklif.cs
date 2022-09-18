using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaTeklif
    {
        public int Sateklifkod { get; set; }
        public string Firmakod { get; set; }
        public string Sabagkod { get; set; }
        public string Uruntipkod { get; set; }
        public string Urunkod { get; set; }
        public string Bicakkodu { get; set; }
        public bool? Bicak { get; set; }
        public bool? Klise { get; set; }
        public DateTime? Baslatarih { get; set; }
        public DateTime? Bitistarih { get; set; }
        public short? Vade { get; set; }
        public string Eksart { get; set; }
        public string Teslimatkod { get; set; }
        public string Teslimatyeri { get; set; }
        public string Sevkiyatkod { get; set; }
        public string Ambalaj { get; set; }
        public string Odemekod { get; set; }
        public byte? Garanti { get; set; }
        public string Imalatcikod { get; set; }
        public string Personelkodu { get; set; }
        public bool Iptal { get; set; }
        public string Tedarikcikodu { get; set; }
        public string Tedarikciadi { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
    }
}
