using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisDetay
    {
        public double? Siparisno { get; set; }
        public string Malzemekodu { get; set; }
        public DateTime? TarihCikis { get; set; }
        public short? EnCikis { get; set; }
        public short? BoyCikis { get; set; }
        public DateTime? TarihGiris { get; set; }
        public short? EnGiris { get; set; }
        public short? BoyGiris { get; set; }
    }
}
