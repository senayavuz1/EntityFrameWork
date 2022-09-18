using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisGider
    {
        public int Siparisno { get; set; }
        public string Giderkod { get; set; }
        public string Urunkod { get; set; }
        public string Makinakodu { get; set; }
        public double Fiyat { get; set; }
        public double Miktar { get; set; }
        public double Tutar { get; set; }
        public string Dovizkod { get; set; }
        public double Kur { get; set; }
        public string Planurunkod { get; set; }
        public double Planlananfiyat { get; set; }
        public double Planlananmiktar { get; set; }
        public double Planlanantutar { get; set; }
        public string Planlanandovizkod { get; set; }
        public double Planlanankur { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
