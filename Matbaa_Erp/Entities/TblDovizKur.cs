using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDovizKur
    {
        public DateTime Tarih { get; set; }
        public string Dovizkod { get; set; }
        public double? Dovizalisf { get; set; }
        public double? Dovizsatisf { get; set; }
        public double? Efektifalisf1 { get; set; }
        public double? Efektifsatisf1 { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
