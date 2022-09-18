using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunResim
    {
        public long ResimId { get; set; }
        public string Urunkod { get; set; }
        public string Resim { get; set; }
        public DateTime Resimtarihi { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
