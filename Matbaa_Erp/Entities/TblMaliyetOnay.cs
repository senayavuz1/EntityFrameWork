using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetOnay
    {
        public long Maliyetonayid { get; set; }
        public int Maliyetkodu { get; set; }
        public DateTime? Tarih { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Onaylayan { get; set; }
    }
}
