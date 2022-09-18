using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblTeklifGonderSonuc
    {
        public string Sonucteklifkod { get; set; }
        public string Kodaciklama { get; set; }
        public bool? Olumlu { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
