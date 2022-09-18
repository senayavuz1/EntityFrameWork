using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTeklifFiyat
    {
        public long Kodu { get; set; }
        public string Sirano { get; set; }
        public string Gonderkodu { get; set; }
        public int Gonderno { get; set; }
        public int Maliyetkodu { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public double Adet { get; set; }
        public double Minadet { get; set; }
        public double Maxadet { get; set; }
        public double Klisemasraf { get; set; }
        public double Bicakmasraf { get; set; }
        public string Urunnot { get; set; }
        public string Urunnot2 { get; set; }
        public string Teklifbirimi { get; set; }
        public double Globalfiyat { get; set; }
        public bool Toplamfiyat { get; set; }
        public double Toplamfiyattutar { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
