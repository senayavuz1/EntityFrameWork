using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisIslem
    {
        public long Siparisislemid { get; set; }
        public long Urunislemid { get; set; }
        public int Siparisno { get; set; }
        public long Siparismakinaid { get; set; }
        public string Islemkod { get; set; }
        public string Dislisayisi { get; set; }
        public double Dislidegeri { get; set; }
        public short Aaadet { get; set; }
        public short Yyadet { get; set; }
        public short Islemsayisi { get; set; }
    }
}
