using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelIzin
    {
        public long Izinkullanid { get; set; }
        public int Izinid { get; set; }
        public string Personelkodu { get; set; }
        public DateTime Cikistarih { get; set; }
        public DateTime Gelistarih { get; set; }
        public short Izingun { get; set; }
        public string Aciklama { get; set; }
    }
}
