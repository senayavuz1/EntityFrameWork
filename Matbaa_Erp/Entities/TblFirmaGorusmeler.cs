using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaGorusmeler
    {
        public long Gorid { get; set; }
        public string Firmakod { get; set; }
        public short Gorusmeno { get; set; }
        public int Teknikno { get; set; }
        public DateTime? Gorusmetarihi { get; set; }
        public string Gorusmetipno { get; set; }
        public string Kisikod { get; set; }
        public string Personelkodu { get; set; }
        public string Gorusmenotu { get; set; }
        public bool Gorusmebitti { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual TblFirma FirmakodNavigation { get; set; }
    }
}
