using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisKlisePantone
    {
        public long Siparispantoneid { get; set; }
        public long Siparisno { get; set; }
        public long Klisepantoneid { get; set; }
        public string Klisekod { get; set; }
        public string Urunkod { get; set; }
        public int Sonno { get; set; }
        public string Pantoneno { get; set; }
        public string Kliseuyumkod { get; set; }
        public string Formul { get; set; }
        public string Aniloxkod { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
