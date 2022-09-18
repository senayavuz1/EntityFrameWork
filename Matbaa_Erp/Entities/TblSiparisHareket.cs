using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisHareket
    {
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public long Urunihtiyacid { get; set; }
        public int Hareketno { get; set; }
        public double Harcananhareket { get; set; }
        public double Bitishareket { get; set; }
        public double Toplammiktar2 { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
