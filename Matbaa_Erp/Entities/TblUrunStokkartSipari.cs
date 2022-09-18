using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunStokkartSipari
    {
        public string Stokkod { get; set; }
        public int Siparisno { get; set; }
        public double Miktar1 { get; set; }
        public double? Miktar2 { get; set; }
        public double Netmiktar { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
