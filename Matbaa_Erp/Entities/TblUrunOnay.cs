using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunOnay
    {
        public string Urunkod { get; set; }
        public DateTime? Uretimonaytarih { get; set; }
        public string Uretimpersonel { get; set; }
        public DateTime? Grafikonaytarih { get; set; }
        public string Grafikpersonel { get; set; }
    }
}
