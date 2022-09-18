using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelIhtiyac
    {
        public string Personelkodu { get; set; }
        public string Ihtiyac { get; set; }
        public string Planlama { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
