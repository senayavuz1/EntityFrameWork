using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKliseFilm
    {
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public string Revizyonkod { get; set; }
        public double Siparismiktar { get; set; }
        public string Birimkod { get; set; }
        public DateTime Siparistarih { get; set; }
        public string Siparisbirim { get; set; }
        public double Siparisfiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Firmakod { get; set; }
        public string Kisikod { get; set; }
        public string Ozelbilgi { get; set; }
        public double? Bicakfiyat { get; set; }
        public string Bdovizkod { get; set; }
        public double? Klisefiyat { get; set; }
        public string Kdovizkod { get; set; }
        public short? Kliseadet { get; set; }
        public bool? Bfaturaet { get; set; }
        public bool? Kfaturaet { get; set; }
        public bool? KontrolKapat { get; set; }
        public DateTime? Kapattarih { get; set; }
        public bool? KontrolDepo { get; set; }
        public double? Toplamalan { get; set; }
        public double? Toplamagirlik { get; set; }
        public double? Toplamadet { get; set; }
        public double? Toplamteslimmiktar { get; set; }
        public string Personelkodu { get; set; }
        public bool? Imalattakip { get; set; }
        public int? Tramyogunlugu { get; set; }
        public double? Malzemetutar { get; set; }
        public double? Makinatutar { get; set; }
        public double? Genelgidertutar { get; set; }
        public double? Ekstragidertutar { get; set; }
        public double? Toplamteslim { get; set; }
        public DateTime? Muhtemeltarih { get; set; }
        public DateTime? Planlanantarih { get; set; }
        public bool? Depodan { get; set; }
        public bool? Ilkdefa { get; set; }
        public string Ilkdefauy { get; set; }
        public bool? Revizyonvar { get; set; }
        public bool? Eskifilmat { get; set; }
        public bool? Revizyonfilmdegil { get; set; }
        public string Revizyonnot { get; set; }
        public string Irsaliyenot { get; set; }
        public string Faturanot { get; set; }
        public string Musterisano { get; set; }
        public string Onayadres { get; set; }
        public string Oncekilot { get; set; }
        public bool? Iptal { get; set; }
        public bool? Prova { get; set; }
        public float? Globalfiyat { get; set; }
        public string Yeniurun { get; set; }
        public string Urunacildi { get; set; }
        public double? Satistltutar { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Ek5 { get; set; }
        public string Ek6 { get; set; }
        public string Ek7 { get; set; }
        public string Ek8 { get; set; }
        public string Ek9 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
