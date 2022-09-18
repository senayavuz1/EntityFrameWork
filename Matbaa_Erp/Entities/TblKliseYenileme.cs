using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKliseYenileme
    {
        public string Klisekod { get; set; }
        public string Yenilemeno { get; set; }
        public string Klisetipkod { get; set; }
        public DateTime? Imaltarihi { get; set; }
        public bool Iptal { get; set; }
        public DateTime? Imhatarihi { get; set; }
        public int Tursayisi { get; set; }
        public double Fiyat { get; set; }
        public double Birimfiyat { get; set; }
        public string Birimdovizkod { get; set; }
        public string Klisesebepkod { get; set; }
        public string Durumkod { get; set; }
        public string Firmakod { get; set; }
        public bool Sipariste { get; set; }
        public bool Kullanimda { get; set; }
        public string Imhasebepkod { get; set; }
        public string Isteyen { get; set; }
        public string Sebepkisi { get; set; }
        public string Siparisno { get; set; }
        public string Aciklama { get; set; }
        public double Miktar1 { get; set; }
        public double Miktar2 { get; set; }
        public double Netmiktar { get; set; }
        public long Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public string Klisetakip { get; set; }
        public string Teslimalan { get; set; }
        public DateTime? Teslimtarihi { get; set; }
        public DateTime? Gondertarihi { get; set; }
        public string Uretimyeri { get; set; }
        public bool Cekirdekvar { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
