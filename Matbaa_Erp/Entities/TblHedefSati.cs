using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblHedefSati
    {
        public DateTime? Tarih { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public float? Hedef { get; set; }
        public string Personelkodu { get; set; }
    }
}
