using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelDil
    {
        public long Dilid { get; set; }
        public string Personelkodu { get; set; }
        public string Dil { get; set; }
        public string Seviye { get; set; }
        public string Yer { get; set; }
    }
}
