using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaIslemUrun
    {
        public int Makinaislemkod { get; set; }
        public string Urunkod { get; set; }
        public bool Enibelli { get; set; }
        public bool Boyubelli { get; set; }
        public bool Enibelirsiz { get; set; }
        public bool Boyubelirsiz { get; set; }
        public double Artien { get; set; }
        public double Artiboy { get; set; }
        public double Artitopen { get; set; }
        public double Artitopboy { get; set; }
        public double Yogunlukgram { get; set; }
        public double Yogunlukadet { get; set; }
        public double Yogunlukalan { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
