using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaSiparisSipari
    {
        public long Sasaid { get; set; }
        public int Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public int Siparisno { get; set; }
        public long Sipihtiyacid { get; set; }
    }
}
