using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaDisli
    {
        public string Makinakodu { get; set; }
        public string Islemkod { get; set; }
        public string Dislisayisi { get; set; }
        public string Dislisayisi2 { get; set; }
        public string Dislisayisi3 { get; set; }
        public float Dislidegeri { get; set; }
        public short Islemunitesayisi { get; set; }
        public double Manyetiken { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
