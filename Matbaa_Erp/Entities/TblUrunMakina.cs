using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunMakina
    {
        public long Urunislemid { get; set; }
        public string Urunkod { get; set; }
        public string Islemkod { get; set; }
        public short Sira { get; set; }
        public string Makinakodu { get; set; }
        public short Ekgecis { get; set; }
        public short Artisetupsure { get; set; }
        public double Artisaattehiz { get; set; }
        public double Dislidegeri { get; set; }
        public string Dislisayisi { get; set; }
        public short Aaadet { get; set; }
        public short Yyadet { get; set; }
        public short Islemsayisi { get; set; }
        public string Aciklama { get; set; }
    }
}
