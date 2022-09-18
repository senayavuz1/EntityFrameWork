using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisKliseAlt
    {
        public long Sipariskliseid { get; set; }
        public long Siparisno { get; set; }
        public string Kliseno { get; set; }
        public string Klisekod { get; set; }
        public string No { get; set; }
        public string Revizyonkod { get; set; }
        public string Baskitipkod { get; set; }
        public string Klisetipkod { get; set; }
        public string Makinakodu { get; set; }
        public string Dislisayisi { get; set; }
        public short Aaadet { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
