using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaDurum
    {
        public long Durumno { get; set; }
        public DateTime Tarih { get; set; }
        public string Firmakod { get; set; }
        public string Durumfirmakod { get; set; }
        public string Aciklama { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual TblFirma FirmakodNavigation { get; set; }
    }
}
