using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMamulTip
    {
        public int Mamultipkod { get; set; }
        public string Kodaciklama { get; set; }
        public byte Hatsayisi { get; set; }
        public string Cokyaprak { get; set; }
        public string Cilt { get; set; }
        public string Cesit { get; set; }
        public string Anatip { get; set; }
        public double Minimumaaaralik { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
