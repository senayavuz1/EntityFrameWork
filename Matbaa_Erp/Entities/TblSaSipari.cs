using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaSipari
    {
        public int Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public string Sabagkod { get; set; }
        public int Istekkod { get; set; }
        public int Sateklifkod { get; set; }
        public string Uruntipkod { get; set; }
        public string Urunkod { get; set; }
        public int Siparisno { get; set; }
        public bool Bicak { get; set; }
        public string Bicakkodu { get; set; }
        public string Satipi { get; set; }
        public bool Klise { get; set; }
        public string Kliseno { get; set; }
        public bool Detaysiz { get; set; }
        public string Birimkod { get; set; }
        public string Urunbirimkod { get; set; }
        public double Birimoran { get; set; }
        public double Miktar1 { get; set; }
        public double Miktar2 { get; set; }
        public int Tabaka { get; set; }
        public double Netmiktar { get; set; }
        public string Kagittipi { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public double Tutar { get; set; }
        public double Kur { get; set; }
        public double Fiyattl { get; set; }
        public double Tutartl { get; set; }
        public double Vade { get; set; }
        public double Kdv { get; set; }
        public DateTime? Siparistarih { get; set; }
        public DateTime? Termintarih { get; set; }
        public string Firmakod { get; set; }
        public string Firmasiparisno { get; set; }
        public string Firmasip { get; set; }
        public string Kisikod { get; set; }
        public string Aciklama { get; set; }
        public string Aciklama2 { get; set; }
        public string Yonetimonay { get; set; }
        public string Yonetimonay2 { get; set; }
        public string Klisefirmakod { get; set; }
        public string Klisegondermekod { get; set; }
        public string Klisesaklamakod { get; set; }
        public bool Kromolin { get; set; }
        public string Personelkodu { get; set; }
        public bool Numunesivar { get; set; }
        public bool? Yeniurun { get; set; }
        public DateTime? Gondermetarih { get; set; }
        public bool KontrolKapat { get; set; }
        public string Tasarimci { get; set; }
        public string Malzemekodu { get; set; }
        public double En { get; set; }
        public double Boy { get; set; }
        public double Tekebaden { get; set; }
        public double Tekebadboy { get; set; }
        public string Tedarikcikodu { get; set; }
        public string Tedarikciadi { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
