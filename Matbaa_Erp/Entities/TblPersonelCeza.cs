using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelCeza
    {
        public int Cezaid { get; set; }
        public string Personelkodu { get; set; }
        public string Adi { get; set; }
        public bool? Ceza { get; set; }
        public string Sebep { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
