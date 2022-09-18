using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblArac
    {
        public int Aracid { get; set; }
        public string Kodaciklama { get; set; }
        public double Tonaj { get; set; }
        public string Kullanma { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
