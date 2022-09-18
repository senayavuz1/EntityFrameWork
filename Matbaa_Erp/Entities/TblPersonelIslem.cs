using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelIslem
    {
        public long PerIslemId { get; set; }
        public long TakipId { get; set; }
        public string Personelkodu { get; set; }
        public string Islemkod { get; set; }
        public string Islemtipkod { get; set; }
    }
}
