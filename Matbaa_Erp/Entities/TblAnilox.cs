using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblAnilox
    {
        public string Aniloxkod { get; set; }
        public string Kodaciklama { get; set; }
        public string Makinakodu { get; set; }
        public int Linecm { get; set; }
        public int Lineinch { get; set; }
        public double Volume { get; set; }
        public double Boyaaktarimi { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
