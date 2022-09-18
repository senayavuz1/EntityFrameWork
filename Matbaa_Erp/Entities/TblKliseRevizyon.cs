using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKliseRevizyon
    {
        public string Klisekod { get; set; }
        public string Revizyonkod { get; set; }
        public string Kliserevizyonsebepkod { get; set; }
        public string Aciklama { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
