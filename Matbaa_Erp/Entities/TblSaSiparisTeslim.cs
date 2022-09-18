using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSaSiparisTeslim
    {
        public long Teslimno { get; set; }
        public long Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public double Teslimmiktar1 { get; set; }
        public double Teslimmiktar2 { get; set; }
        public double Teslimnetmiktar { get; set; }
        public double Teslimkur { get; set; }
        public DateTime? Teslimtarih { get; set; }
        public string Irsaliyeno { get; set; }
        public DateTime? Irsaliyetarih { get; set; }
        public int Hareketno { get; set; }
        public string Faturano { get; set; }
        public DateTime? Faturatarih { get; set; }
        public double Faturafiyat { get; set; }
        public bool Faturalandi { get; set; }
        public string Dovizkod { get; set; }
        public double Iskonto { get; set; }
        public DateTime? Kontroltarih { get; set; }
        public string Ambalajbutunluk { get; set; }
        public string Sevkaraci { get; set; }
        public string Paletuygunluk { get; set; }
        public string Etiketkontrolu { get; set; }
        public string Bobinsarimyonu { get; set; }
        public string Korona { get; set; }
        public string Yapisma { get; set; }
        public string Cekmekontrolu { get; set; }
        public string Olcukontrolu { get; set; }
        public string Analizsertifikasi { get; set; }
        public string Mikronkontolu { get; set; }
        public string Kabuldurumu { get; set; }
        public string Kontoleden { get; set; }
        public string Onayliyan { get; set; }
    }
}
