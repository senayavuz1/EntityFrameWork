using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaGider
    {
        public string Makinakodu { get; set; }
        public double? Genelgiderpayi { get; set; }
        public double? Iscilikgideri { get; set; }
        public double? Elektrikgideri { get; set; }
        public string Gidergrupkod { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
