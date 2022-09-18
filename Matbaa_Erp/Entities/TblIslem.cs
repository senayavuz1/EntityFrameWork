using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblIslem
    {
        public string Islemkod { get; set; }
        public string Kodaciklama { get; set; }
        public string Islemtipkod { get; set; }
        public string Baskitipkod { get; set; }
        public string Bicaktipkod { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Fiyatbirim { get; set; }
        public bool Yaldiz { get; set; }
        public bool Yaldizbaski { get; set; }
        public string Bilgi { get; set; }
        public double Minalan { get; set; }
        public double Maksalan { get; set; }
        public string Teklifteyaz { get; set; }
        public string Islemaktif { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
