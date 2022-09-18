using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblVardiya
    {
        public int Vardiyano { get; set; }
        public int Siparisno { get; set; }
        public string Makinakodu { get; set; }
        public double Zamanfiretoplami { get; set; }
        public double Urunfirealan { get; set; }
        public double Urunalan { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
