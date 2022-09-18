using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblHareketTip
    {
        public string Harekettipkod { get; set; }
        public string Kodaciklama { get; set; }
        public bool? Hareketsekli { get; set; }
        public bool? Siparis { get; set; }
        public bool? Dis { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
