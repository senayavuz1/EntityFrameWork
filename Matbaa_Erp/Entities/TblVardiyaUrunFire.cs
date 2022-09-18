using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblVardiyaUrunFire
    {
        public int Vardiyano { get; set; }
        public int Vardiyaaltno { get; set; }
        public string Urunfirekod { get; set; }
        public string Urunkod { get; set; }
        public string Siparisurunkod { get; set; }
        public string Aciklama { get; set; }
        public double Miktar { get; set; }
        public double Netmiktar { get; set; }
        public string Birimkod { get; set; }
        public int Siparisno { get; set; }
        public string Islemkod { get; set; }
        public string Personelkodu { get; set; }
        public string Makinakodu { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
