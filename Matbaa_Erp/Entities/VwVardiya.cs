using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwVardiya
    {
        public int Vardiyano { get; set; }
        public int Siparisno { get; set; }
        public int? Vardiyaaltno { get; set; }
        public DateTime? Baslangicgun { get; set; }
        public DateTime? Baslangicsaat { get; set; }
        public DateTime? Bitisgun { get; set; }
        public DateTime? Bitissaat { get; set; }
        public string Personelkodu { get; set; }
        public short? Netsure { get; set; }
        public string Makinakodu { get; set; }
        public double? Uretimmiktar { get; set; }
        public double? Neturetim { get; set; }
        public string Makinaadi { get; set; }
        public string Adisoyadi { get; set; }
        public string Siparisurunadi { get; set; }
        public double? Plansure { get; set; }
        public double? Planmiktar { get; set; }
        public string Kisaad { get; set; }
        public double? Siparismiktar { get; set; }
        public int? Topsetupsure { get; set; }
        public string Harcananurunadi { get; set; }
        public string Urunkod { get; set; }
        public double? Tekebadboy { get; set; }
        public double? Aabosluk { get; set; }
        public short? Bicakaaadet { get; set; }
        public string Makinabirimkod { get; set; }
        public byte? Planlamasirasi { get; set; }
        public short? Sira { get; set; }
        public double? Alan { get; set; }
        public double? Topalan { get; set; }
        public double? Tekebaden { get; set; }
        public double? Zamanfiretoplami { get; set; }
        public double? Urunfirealan { get; set; }
        public double? Urunalan { get; set; }
        public string Malzemekod2 { get; set; }
        public string Laminasyoncinsi { get; set; }
        public bool? Kkontrol { get; set; }
        public short? Yikananunite { get; set; }
        public string Kliseno { get; set; }
    }
}
