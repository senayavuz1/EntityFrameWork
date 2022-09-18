using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaFirma
    {
        public int Firmafirmaid { get; set; }
        public string Firmakod { get; set; }
        public string Firma { get; set; }
        public string Alicikod { get; set; }
        public string Saticikod { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
        public short FirmId { get; set; }

        public virtual TblFirm Firm { get; set; }
        public virtual TblFirma FirmakodNavigation { get; set; }
    }
}
