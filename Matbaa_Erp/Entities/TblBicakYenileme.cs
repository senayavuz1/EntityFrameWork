using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBicakYenileme
    {
        public string Bicakkodu { get; set; }
        public string Yenilemeno { get; set; }
        public string Serino { get; set; }
        public bool Iptal { get; set; }
        public string Durumkod { get; set; }
        public string Firmakod { get; set; }
        public DateTime? Imaltarihi { get; set; }
        public DateTime? Imhatarihi { get; set; }
        public DateTime? Fiilitarih { get; set; }
        public string Bicaksebepkod { get; set; }
        public int Tursayisi { get; set; }
        public double Fiyat { get; set; }
        public bool Kullanimda { get; set; }
        public bool Sipariste { get; set; }
        public int Sasiparisno { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
    }
}
