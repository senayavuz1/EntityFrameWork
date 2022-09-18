using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaPersonel
    {
        public long FirmaPersId { get; set; }
        public string Firmakod { get; set; }
        public short FirmId { get; set; }
        public string Personelkodu { get; set; }
        public string Personelgrupkod { get; set; }
        public string Aciklama { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual TblFirma FirmakodNavigation { get; set; }
    }
}
