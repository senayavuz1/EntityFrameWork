using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaKontakt
    {
        public string Firmakod { get; set; }
        public string Kisikod { get; set; }
        public string Ad { get; set; }
        public string Iptalet { get; set; }
        public string Departman { get; set; }
        public string Gorevi { get; set; }
        public DateTime? Dogumtarihi { get; set; }
        public string Hobiler { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Postakod { get; set; }
        public string Ilcekod { get; set; }
        public string Ilkod { get; set; }
        public string Ulkekod { get; set; }
        public string Telefon1 { get; set; }
        public string Mail { get; set; }
        public string Esadi { get; set; }
        public DateTime? Esdogum { get; set; }
        public DateTime? Evliliktarih { get; set; }
        public string Spor { get; set; }
        public string Takimi { get; set; }
        public string Evhayvani { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual TblFirma FirmakodNavigation { get; set; }
    }
}
