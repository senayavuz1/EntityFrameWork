using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaTeslimat
    {
        public TblFirmaTeslimat()
        {
            TblFirmaTeslimatEtikets = new HashSet<TblFirmaTeslimatEtiket>();
        }

        public long Firmateslimatid { get; set; }
        public string Firmakod { get; set; }
        public string Subekod { get; set; }
        public string Subead { get; set; }
        public string Teslimatadres1 { get; set; }
        public string Teslimatadres2 { get; set; }
        public string Postakod { get; set; }
        public string Ilcekod { get; set; }
        public string Ilkod { get; set; }
        public string Ulkekod { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Faks1 { get; set; }
        public string Faks2 { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public string Vergidairesi { get; set; }
        public string Vergino { get; set; }
        public string Tckimlikno { get; set; }
        public bool Kullanilmiyor { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual TblFirma FirmakodNavigation { get; set; }
        public virtual ICollection<TblFirmaTeslimatEtiket> TblFirmaTeslimatEtikets { get; set; }
    }
}
