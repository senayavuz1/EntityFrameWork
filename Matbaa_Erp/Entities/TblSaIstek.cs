using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaIstek
    {
        public int Istekkod { get; set; }
        public string Uruntip { get; set; }
        public bool? Bicak { get; set; }
        public bool? Klise { get; set; }
        public string Sabagkod { get; set; }
        public string Urunadi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? Termintarih { get; set; }
        public string Birimkod { get; set; }
        public double? Miktar1 { get; set; }
        public double? Miktar2 { get; set; }
        public double? Netmiktar { get; set; }
        public string Aciklama { get; set; }
        public string Personelkodu { get; set; }
        public string Istenen { get; set; }
        public string Siparisedondu { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
