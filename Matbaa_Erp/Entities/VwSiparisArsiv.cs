using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwSiparisArsiv
    {
        public string Kisaad { get; set; }
        public string Urunkod { get; set; }
        public string Urunadi { get; set; }
        public double Siparismiktar { get; set; }
        public string Firmakod { get; set; }
        public string Personelkodu { get; set; }
        public string Personelkodu2 { get; set; }
        public DateTime Siparistarih { get; set; }
        public double Toplamteslim { get; set; }
        public int Siparisno { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
        public bool Iptal { get; set; }
        public double Siparisfiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Dovizaciklama { get; set; }
    }
}
