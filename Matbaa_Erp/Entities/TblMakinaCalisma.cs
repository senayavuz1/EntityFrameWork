using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaCalisma
    {
        public string Makinakodu { get; set; }
        public DateTime Tarih { get; set; }
        public bool? Calisiyor { get; set; }
        public DateTime? Baslamasaat { get; set; }
        public DateTime? Bitissaat { get; set; }
    }
}
