using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblGrafikOnay
    {
        public long Grafno { get; set; }
        public long Grafikno { get; set; }
        public DateTime? Gidistarih { get; set; }
        public DateTime? Gelistarih { get; set; }
        public string Grafikislemkod { get; set; }
        public string Aciklama { get; set; }
    }
}
