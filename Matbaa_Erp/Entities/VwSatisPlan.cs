using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwSatisPlan
    {
        public long Gorid { get; set; }
        public string Firmakod { get; set; }
        public short Gorusmeno { get; set; }
        public string Kisaad { get; set; }
        public long? Randevuno { get; set; }
        public DateTime? Randevutarihi { get; set; }
        public string BasSaat { get; set; }
        public string Personelkodu { get; set; }
        public string Sure { get; set; }
        public string RandevuSaat { get; set; }
        public string Bilgi { get; set; }
        public int Teknikno { get; set; }
        public DateTime? Gorusmetarihi { get; set; }
        public string Gorusmetipno { get; set; }
        public string Kisikod { get; set; }
        public string Personelkodugorusme { get; set; }
        public string Gorusmenotu { get; set; }
        public bool Gorusmebitti { get; set; }
        public string Adisoyadi { get; set; }
        public string Adisoyadigorusme { get; set; }
        public string Ad { get; set; }
        public string Tipaciklama { get; set; }
    }
}
