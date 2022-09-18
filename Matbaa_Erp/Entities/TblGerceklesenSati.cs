using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblGerceklesenSati
    {
        public DateTime? Tarih { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public double Gerceklesen { get; set; }
        public double Fatura { get; set; }
    }
}
