using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwSipari
    {
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public double Siparismiktar { get; set; }
        public string Birimkod { get; set; }
        public DateTime Siparistarih { get; set; }
        public string Siparisbirim { get; set; }
        public double Siparisfiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Firmakod { get; set; }
        public bool KontrolKapat { get; set; }
        public string Urunadi { get; set; }
        public string Musterikod { get; set; }
        public string Ticariad { get; set; }
        public string Kisaad { get; set; }
    }
}
