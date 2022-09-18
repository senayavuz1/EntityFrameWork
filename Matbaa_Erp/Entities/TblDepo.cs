using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDepo
    {
        public string Depokod { get; set; }
        public string Kodaciklama { get; set; }
        public string Durumu { get; set; }
        public string Depotipi { get; set; }
        public short FirmId { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
