using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrun
    {
        public string Urunkod { get; set; }
        public string Revizyonkod { get; set; }
        public string Uruntipkod { get; set; }
        public string Musterikod { get; set; }
        public string Mamultip { get; set; }
        public int Mamultipkod { get; set; }
        public string Slevetip { get; set; }
        public string Urunadi { get; set; }
        public string Urunfaturaadi { get; set; }
        public string UrunadiIngilizce { get; set; }
        public string Spekkod { get; set; }
        public string Birimkod { get; set; }
        public double Tekebadboy { get; set; }
        public double Tekebaden { get; set; }
        public double Tekebadyukseklik { get; set; }
        public short Yyadet { get; set; }
        public double Aabosluk { get; set; }
        public double Yybosluk { get; set; }
        public short Yybitisikadet { get; set; }
        public double Baskiaabosluk { get; set; }
        public double Lf { get; set; }
        public double Yapistirmapayi { get; set; }
        public double Cl { get; set; }
        public string Malzemekod { get; set; }
        public bool Malzemezorunlu { get; set; }
        public string Malzemekod2 { get; set; }
        public short Malzemeek { get; set; }
        public short Bicakek { get; set; }
        public short Makinaek { get; set; }
        public string Kliseno { get; set; }
        public string Yapiskankod { get; set; }
        public string Tasiyicikod { get; set; }
        public string Laminasyoncinsi { get; set; }
        public string Bicakkodu { get; set; }
        public double Minstok { get; set; }
        public double Maxstok { get; set; }
        public double Siparismiktar { get; set; }
        public string Muhasebekod { get; set; }
        public string Urunnot { get; set; }
        public string Imalatcikod { get; set; }
        public bool Adettakim { get; set; }
        public short Takimmiktar { get; set; }
        public string Rulobirim { get; set; }
        public bool Adettakim2 { get; set; }
        public short Takimmiktar2 { get; set; }
        public string Yarimamulkod { get; set; }
        public string Kullanimalanikod { get; set; }
        public string Yapisalkod1 { get; set; }
        public string Yapisalkod2 { get; set; }
        public string Yapisalkod3 { get; set; }
        public string Opaklikkod { get; set; }
        public string Parlaklikkod { get; set; }
        public string Cekeryuzde { get; set; }
        public double Yogunluk { get; set; }
        public short Kalinlik { get; set; }
        public double Gramaj { get; set; }
        public double Gramajbutun { get; set; }
        public string Paketmiktar { get; set; }
        public string Paketbirimkod { get; set; }
        public string Iccap { get; set; }
        public double Fiyat { get; set; }
        public double Maliyetfiyat { get; set; }
        public double Acilisfiyat { get; set; }
        public string Uretimonay { get; set; }
        public DateTime? Uretimonaytarih { get; set; }
        public string Uretimpersonel { get; set; }
        public string Grafikonay { get; set; }
        public DateTime? Grafikonaytarih { get; set; }
        public string Grafikpersonel { get; set; }
        public double Alan { get; set; }
        public double Agirlik { get; set; }
        public bool Ambalaj { get; set; }
        public double Depolama { get; set; }
        public string Sabagkod { get; set; }
        public int Maliyetkodu { get; set; }
        public double Adetagirlik { get; set; }
        public double Adeten { get; set; }
        public double Adetboy { get; set; }
        public string Genelkod { get; set; }
        public string Firmakod { get; set; }
        public string Maliyetbirimkod { get; set; }
        public string Imalatkod { get; set; }
        public string Imalatadi { get; set; }
        public string Baskitipkod { get; set; }
        public string Eskiurunkod { get; set; }
        public bool Urunkullanilmiyor { get; set; }
        public double Uruneken { get; set; }
        public double Tasiyicieken { get; set; }
        public string Gidergrupkod { get; set; }
        public double Konsinyemiktar { get; set; }
        public double Konsinyealan { get; set; }
        public DateTime? Konsinyetarih { get; set; }
        public string Hammaddefiyatbirimi { get; set; }
        public string Resim { get; set; }
        public DateTime? Resimtarihi { get; set; }
        public string Uygulamasekli { get; set; }
        public string Holtmelt { get; set; }
        public string Perfore { get; set; }
        public bool Devamlilik { get; set; }
        public string Arsivno { get; set; }
        public string Boyayogunluk { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
