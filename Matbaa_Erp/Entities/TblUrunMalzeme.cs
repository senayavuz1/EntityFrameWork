using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunMalzeme
    {
        public long Urunmalzemeid { get; set; }
        public string Urunkod { get; set; }
        public int Sira { get; set; }
        public string Yapisalkod { get; set; }
        public string Malzemekod { get; set; }
        public string Urunbirimkod { get; set; }
        public long Urunislemid { get; set; }
        public bool? Hammadde { get; set; }
        public double Gramaj { get; set; }
        public double Malzemeuretimeni { get; set; }
        public byte Yyadet { get; set; }
        public string Hamyarimamul { get; set; }
    }
}
