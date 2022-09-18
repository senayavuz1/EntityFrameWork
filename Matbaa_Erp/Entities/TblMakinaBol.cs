using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaBol
    {
        public string Makinakodu { get; set; }
        public string Islemkod { get; set; }
        public short? Bol { get; set; }
        public short? Cekim { get; set; }
    }
}
