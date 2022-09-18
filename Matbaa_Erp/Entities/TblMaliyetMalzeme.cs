using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetMalzeme
    {
        public long Maliyetmalzemeid { get; set; }
        public long Maliyetkodu { get; set; }
        public int Sira { get; set; }
        public string Yapisalkod { get; set; }
        public string Urunkod { get; set; }
        public string Urunbirimkod { get; set; }
        public long Maliyetislemid { get; set; }
        public bool Hammadde { get; set; }
        public double Gramaj { get; set; }
        public double Hammaddefiyat { get; set; }
        public string Parabirimi { get; set; }
        public double Fiyateurokg { get; set; }
        public double Fiyateuroalan { get; set; }
        public double Malzemeuretimeni { get; set; }
    }
}
