using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblVardiyaUrunDetay
    {
        public int Vardiyano { get; set; }
        public int Vardiyaaltno { get; set; }
        public string Urunkod { get; set; }
        public string Stokkod { get; set; }
        public int Hareketno { get; set; }
        public double Kullanilanmiktar1 { get; set; }
        public double Kullanilanmiktar2 { get; set; }
        public double Netkullanilan { get; set; }
        public short Hammaddeenadet { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
