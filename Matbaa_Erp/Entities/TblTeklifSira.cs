using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTeklifSira
    {
        public long Teklifsiraid { get; set; }
        public long Kodu { get; set; }
        public string Sirano { get; set; }
        public long Maliyetkodu { get; set; }
        public double Klisemasraf { get; set; }
        public string Kdovizkod { get; set; }
        public double Bicakmasraf { get; set; }
        public string Bdovizkod { get; set; }
        public string Uruntipkod { get; set; }
        public bool Teklifonay { get; set; }
        public string Urunnot { get; set; }
        public string Urunnot2 { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
