using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelEgitim
    {
        public int PersonelEgitimId { get; set; }
        public string Personelkodu { get; set; }
        public string Verenadi { get; set; }
        public string Konu { get; set; }
        public DateTime Tarih { get; set; }
        public double Sure { get; set; }
        public string Aciklama { get; set; }
        public bool Firmaici { get; set; }
    }
}
