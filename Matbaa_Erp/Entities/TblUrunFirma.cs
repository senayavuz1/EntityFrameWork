using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunFirma
    {
        public long Urunfirmaid { get; set; }
        public string Urunkod { get; set; }
        public string Firmakod { get; set; }
        public int Maliyetkodu { get; set; }
        public short Urunno { get; set; }
        public string Urunfaturaadi { get; set; }
        public string Urunmusterikod { get; set; }
        public string Uruncesidi { get; set; }
    }
}
