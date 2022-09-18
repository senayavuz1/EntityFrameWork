using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblHatirlama
    {
        public long Hatirid { get; set; }
        public long Hatirno { get; set; }
        public long Gorid { get; set; }
        public string Firmakod { get; set; }
        public string Kisikod { get; set; }
        public bool? Kisinin { get; set; }
        public bool? Cocuk { get; set; }
        public string Hatirlama { get; set; }
        public DateTime? Tarih { get; set; }
        public short? Siklik { get; set; }
        public string Siklikadi { get; set; }
        public string Gun { get; set; }
        public string Hafta { get; set; }
        public string Ay { get; set; }
        public string Ucay { get; set; }
        public string Altiay { get; set; }
        public string Yil { get; set; }
        public bool? Iptal { get; set; }
        public string Aciklama { get; set; }
    }
}
