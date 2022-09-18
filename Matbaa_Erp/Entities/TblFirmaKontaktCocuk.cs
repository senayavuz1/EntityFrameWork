using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaKontaktCocuk
    {
        public string Firmakod { get; set; }
        public string Kisikod { get; set; }
        public string Cocukadi { get; set; }
        public DateTime? Tarih { get; set; }
        public string Bilgi { get; set; }
        public int? Hatirno { get; set; }
    }
}
