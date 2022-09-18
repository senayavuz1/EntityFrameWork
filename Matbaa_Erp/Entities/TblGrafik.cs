using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblGrafik
    {
        public long Grafikno { get; set; }
        public string Grafikadi { get; set; }
        public string Firmakod { get; set; }
        public string Kliseno { get; set; }
        public byte Hat { get; set; }
        public string Isinsekli { get; set; }
        public DateTime? Baslatarih { get; set; }
        public DateTime? Bitistarih { get; set; }
        public string Aciklama { get; set; }
        public string Gecikme { get; set; }
        public string Grafikdurumkod { get; set; }
        public short Netsure { get; set; }
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public long Maliyetkodu { get; set; }
        public string Personelkodu { get; set; }
        public string Montaj { get; set; }
        public string Takip { get; set; }
        public short Sirala { get; set; }
        public short Siralagrafiker { get; set; }
        public string Akisyonu { get; set; }
        public string Uygulamasekli { get; set; }
        public string Gelenorjinal { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
