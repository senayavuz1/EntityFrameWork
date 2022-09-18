using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisIhtiyac
    {
        public long Sipihtiyacid { get; set; }
        public long Urunihtiyacid { get; set; }
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public double Miktar { get; set; }
        public string Birimkod { get; set; }
        public string Birim { get; set; }
        public double En { get; set; }
        public bool? Hammadde { get; set; }
        public string Islemkod { get; set; }
        public bool Fason { get; set; }
        public double Fire { get; set; }
        public string Ihtiyactakip { get; set; }
        public string Ihtiyacnotu { get; set; }
    }
}
