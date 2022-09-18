using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDurum
    {
        public string Durumkod { get; set; }
        public string Kodaciklama { get; set; }
        public bool? Kullanimda { get; set; }
        public bool? Sipariste { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
