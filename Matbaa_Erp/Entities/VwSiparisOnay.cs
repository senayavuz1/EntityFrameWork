using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwSiparisOnay
    {
        public int Siparisno { get; set; }
        public string Urunkod { get; set; }
        public double Siparismiktar { get; set; }
        public string Birimkod { get; set; }
        public DateTime Siparistarih { get; set; }
        public string Siparisbirim { get; set; }
        public double Siparisfiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Firmakod { get; set; }
        public bool KontrolKapat { get; set; }
        public string Urunadi { get; set; }
        public string Musterikod { get; set; }
        public string Ticariad { get; set; }
        public string Kisaad { get; set; }
        public string Simge { get; set; }
        public string Dovizaciklama { get; set; }
        public double Onaydakirisk { get; set; }
        public string Muhasebeonay { get; set; }
        public string Muhasebeonaylayan { get; set; }
        public DateTime? Muhasebeonaytarih { get; set; }
        public string Yonetimonay { get; set; }
        public string Yonetimonaylayan { get; set; }
        public DateTime? Yonetimonaytarih { get; set; }
        public string Yonetimonay2 { get; set; }
        public string Yonetimonaylayan2 { get; set; }
        public DateTime? Yonetimonaytarih2 { get; set; }
        public double Satistltutar { get; set; }
        public string Muhasebekod { get; set; }
        public string Odemesekli { get; set; }
        public string Odemekod { get; set; }
        public string Odemeadi { get; set; }
        public double Onaydakibakiye { get; set; }
        public string Bakiyedovizkod { get; set; }
        public string Riskdovizkod { get; set; }
        public string Bakiyedovizad { get; set; }
        public string Riskdovizad { get; set; }
        public bool Prova { get; set; }
        public string Satisadisoyadi { get; set; }
        public string Satisadisoyadi2 { get; set; }
    }
}
