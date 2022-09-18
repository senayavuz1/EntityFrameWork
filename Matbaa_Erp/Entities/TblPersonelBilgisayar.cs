using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelBilgisayar
    {
        public long Bilid { get; set; }
        public string Personelkodu { get; set; }
        public string Adi { get; set; }
        public string Cinsi { get; set; }
        public string Seviye { get; set; }
        public string Aciklama { get; set; }
    }
}
