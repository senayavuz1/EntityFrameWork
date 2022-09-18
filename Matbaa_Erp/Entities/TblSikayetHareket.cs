using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSikayetHareket
    {
        public int HareketId { get; set; }
        public int Sikayetno { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? Anasikayet { get; set; }
        public string Hareketadi { get; set; }
        public string Hareketno { get; set; }
        public string Aciklama { get; set; }
        public double? Hareketmiktar { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
