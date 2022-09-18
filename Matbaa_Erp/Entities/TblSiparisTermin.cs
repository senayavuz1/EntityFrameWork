using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisTermin
    {
        public long Terminid { get; set; }
        public int Siparisno { get; set; }
        public double Siparismiktar { get; set; }
        public DateTime Termintarih { get; set; }
        public string Firmakod { get; set; }
        public string Subekod { get; set; }
        public bool Stok { get; set; }
        public short Iccap { get; set; }
        public short Discap { get; set; }
        public int Bobindeadet { get; set; }
        public string Bobindebirim { get; set; }
        public string Akisyonu { get; set; }
        public short Musteriyyadet { get; set; }
        public string Sevkiyatkod { get; set; }
        public string Terminnot { get; set; }
    }
}
