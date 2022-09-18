using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBicakTip
    {
        public string Bicaktipkod { get; set; }
        public string Kodaciklama { get; set; }
        public string Simge { get; set; }
        public bool Dislivar { get; set; }
        public bool Dislisizvar { get; set; }
        public bool Yandondur { get; set; }
        public double Dislidegeri { get; set; }
        public double Maksboy { get; set; }
        public double Minboy { get; set; }
        public double Maksen { get; set; }
        public double Minen { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
