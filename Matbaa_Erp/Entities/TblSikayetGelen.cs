using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSikayetGelen
    {
        public int Sikayetno { get; set; }
        public string Sikayettipi { get; set; }
        public string Iadedurum { get; set; }
        public DateTime? Sikayettarih { get; set; }
        public string Firmakod { get; set; }
        public string Kisikod { get; set; }
        public string Personelkodu { get; set; }
        public string Urunkod { get; set; }
        public int Siparisno { get; set; }
        public DateTime? Teslimtarih { get; set; }
        public double Toplamadet { get; set; }
        public int Sevkiyatno { get; set; }
        public double Sevkadet { get; set; }
        public string Irsaliyeno { get; set; }
        public long Sevkno { get; set; }
        public string Aciklama { get; set; }
        public string Dofkod { get; set; }
        public DateTime? Iadetarihi { get; set; }
        public string Musterisikayetno { get; set; }
        public double Zarartutari { get; set; }
        public string Resim { get; set; }
        public bool Bedelsiz { get; set; }
        public string Acik { get; set; }
        public string Degerlendirme { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
