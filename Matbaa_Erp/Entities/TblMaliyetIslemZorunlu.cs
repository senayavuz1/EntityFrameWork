using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetIslemZorunlu
    {
        public long MaliyetislemZid { get; set; }
        public int Maliyetkodu { get; set; }
        public string Islemkod { get; set; }
        public string Islemtipkod { get; set; }
        public string Makinakodu { get; set; }
    }
}
