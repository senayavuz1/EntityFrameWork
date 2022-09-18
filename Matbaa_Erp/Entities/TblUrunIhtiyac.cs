using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunIhtiyac
    {
        public long Urunihtiyacid { get; set; }
        public string Urunkod { get; set; }
        public string Firmakod { get; set; }
        public string Ambalajkod { get; set; }
        public double Adetoran { get; set; }
        public double Alanoran { get; set; }
        public double Agirlikoran { get; set; }
        public double Urunoran { get; set; }
        public double Ambalajoran { get; set; }
        public string Urunbirimtip { get; set; }
        public string Ambalajbirimkod { get; set; }
        public bool Siparisaktar { get; set; }
        public bool Ambalaj { get; set; }
        public bool? Eni { get; set; }
        public double En { get; set; }
        public bool Hammadde { get; set; }
        public long Urunislemid { get; set; }
        public string Islemkod { get; set; }
        public string Aciklama { get; set; }
        public long Urunmalzemeid { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
