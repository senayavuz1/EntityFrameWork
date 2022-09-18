using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunStokkart
    {
        public long Stokid { get; set; }
        public string Stokkod { get; set; }
        public string Uruntipkod { get; set; }
        public string Urunkod { get; set; }
        public short Urunno { get; set; }
        public string Firmakod { get; set; }
        public double Miktar1 { get; set; }
        public double Miktar2 { get; set; }
        public int Tabaka { get; set; }
        public double Netmiktar { get; set; }
        public string Birimkod { get; set; }
        public double Stokgramaji { get; set; }
        public DateTime Tarih { get; set; }
        public string Kagittipi { get; set; }
        public string Setmi { get; set; }
        public double Tabakaboy { get; set; }
        public string Depokod { get; set; }
        public string Aciklama { get; set; }
        public string Uyarinotu { get; set; }
        public int Sevkiyatno { get; set; }
        public int Sevkiyatno2 { get; set; }
        public int Koliadet { get; set; }
        public int Ruloadet { get; set; }
        public string Urunadet { get; set; }
        public double Toplamadet { get; set; }
        public string Rafkodu { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public double Fiyattl { get; set; }
        public int Siparisno { get; set; }
        public string Gideceksiparisno { get; set; }
        public string Giriskkno { get; set; }
        public int Teslimno { get; set; }
        public string Kkpersonelkodu { get; set; }
        public string Dosyano { get; set; }
        public double Sevkbekleyenmiktar { get; set; }
        public string Faturaedildi { get; set; }
        public long Faturasevkno { get; set; }
        public string Sarfedildi { get; set; }
        public long Sikayetno { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
