using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunStokkartIade
    {
        public int Vardiyano { get; set; }
        public int Vardiyaaltno { get; set; }
        public string Urunkod { get; set; }
        public string Stokkod { get; set; }
        public int Hareketno { get; set; }
        public double Iademiktar1 { get; set; }
        public double Iademiktar2 { get; set; }
        public double Netiade { get; set; }
        public bool Iadealindi { get; set; }
        public DateTime? Iadealinditarih { get; set; }
        public bool Etiketbasildi { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
