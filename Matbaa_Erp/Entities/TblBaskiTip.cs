using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBaskiTip
    {
        public string Baskitipkod { get; set; }
        public string Kodaciklama { get; set; }
        public double Klisefiyat { get; set; }
        public string Klisedovizkod { get; set; }
        public string Klisefiyatbirim { get; set; }
        public double Boyayogunlugu { get; set; }
        public double Boyafiyat { get; set; }
        public string Boyadovizkod { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
