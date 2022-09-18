using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelSaglik
    {
        public long Saglikid { get; set; }
        public string Personelkodu { get; set; }
        public DateTime Tarih { get; set; }
        public string Rahatsizlik { get; set; }
        public string Bulgu { get; set; }
        public string Tani { get; set; }
        public string Tedavi { get; set; }
    }
}
