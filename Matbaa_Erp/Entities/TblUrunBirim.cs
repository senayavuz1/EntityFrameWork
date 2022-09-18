using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunBirim
    {
        public int Birimno { get; set; }
        public string Urunkod { get; set; }
        public string Birimkod { get; set; }
        public string Ekbirimkod { get; set; }
        public double Miktar { get; set; }
        public double Ekmiktar { get; set; }
        public double Birimoran { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
