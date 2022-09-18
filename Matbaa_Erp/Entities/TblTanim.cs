using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTanim
    {
        public int Tid { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public string Tip { get; set; }
        public int? TipInt { get; set; }
    }
}
