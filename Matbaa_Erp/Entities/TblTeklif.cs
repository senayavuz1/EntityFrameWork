using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTeklif
    {
        public long Kodu { get; set; }
        public int Gonderno { get; set; }
        public string Firmakod { get; set; }
        public DateTime Tarih { get; set; }
        public string Eksartlar { get; set; }
        public string Sevkiyatkod { get; set; }
        public string Teslimatkod { get; set; }
        public string Durumteklifkod { get; set; }
        public string Kisikod { get; set; }
        public bool? Arsiv { get; set; }
        public bool? Hatirlatma { get; set; }
        public DateTime? Hatirlatmatarih { get; set; }
        public string Hatirlatmanot { get; set; }
        public string Avans { get; set; }
        public string Il { get; set; }
        public string Opsiyonkod { get; set; }
        public string Personelkodu { get; set; }
        public bool Klisegoster { get; set; }
        public double Klisemasraf { get; set; }
        public string Kdovizkod { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
