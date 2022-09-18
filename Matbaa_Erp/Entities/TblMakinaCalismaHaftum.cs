using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaCalismaHaftum
    {
        public string Makinakodu { get; set; }
        public string Gun { get; set; }
        public bool? Calisiyor { get; set; }
        public DateTime? Baslamasaat { get; set; }
        public DateTime? Bitissaat { get; set; }
    }
}
