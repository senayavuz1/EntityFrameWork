using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetAdet
    {
        public int Maliyetkodu { get; set; }
        public double Adet { get; set; }
        public double Minadet { get; set; }
        public double Maxadet { get; set; }
        public double Carpannet { get; set; }
        public double Carpan { get; set; }
        public double Fiyat { get; set; }
        public string Birimkod { get; set; }
        public string Teklifbirimi { get; set; }
        public double Fire { get; set; }
        public double Artifire { get; set; }
        public double Makinagider { get; set; }
        public double Elektirkgider { get; set; }
        public double Iscilikgider { get; set; }
        public double Amortismangider { get; set; }
        public double Sarfmalzemefiyat { get; set; }
        public double Yardhammaddetutar { get; set; }
        public double Hammaddetutar { get; set; }
        public double Islemtutar { get; set; }
        public double Nakliyetutar { get; set; }
        public double Yonetimgider { get; set; }
        public double Yonetimgidernet { get; set; }
        public bool Toplamfiyat { get; set; }
        public double Toplamfiyattutar { get; set; }
        public short Vade { get; set; }
        public double Uzunluk { get; set; }
        public double Birimalanfiyat { get; set; }
        public double Birimagirlikfiyat { get; set; }
        public double Birimadetfiyat { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
