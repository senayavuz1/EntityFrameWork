using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaSiparisTeslimDetay
    {
        public long Detayno { get; set; }
        public long Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public int Teslimno { get; set; }
        public double Boy { get; set; }
        public string Partino { get; set; }
    }
}
