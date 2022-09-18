using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMaliyetIslem
    {
        public long Maliyetislemid { get; set; }
        public int Maliyetkodu { get; set; }
        public short Ekgecis { get; set; }
        public byte Sira { get; set; }
        public string Takipadi { get; set; }
        public string Islemkod { get; set; }
        public string Islemtipkod { get; set; }
        public string Makinakodu { get; set; }
        public short Islemtekrari { get; set; }
        public double Fiyat { get; set; }
        public string Dovizkod { get; set; }
        public string Birimkod { get; set; }
        public string Ekstragideradi { get; set; }
        public string Ektragiderbirim { get; set; }
        public double Ekstragiderfiyat { get; set; }
        public string Ektradovizkod { get; set; }
        public string Dislisayisi { get; set; }
        public short Aaadet { get; set; }
        public short Yyadet { get; set; }
        public float Dislidegeri { get; set; }
        public double Yuzdefire { get; set; }
        public double Setupfire { get; set; }
        public string Aciklama { get; set; }
        public double Setupfiyat { get; set; }
        public string Setupdovizkod { get; set; }
        public double Artisaattehiz { get; set; }
        public double Boyabirimfiyat { get; set; }
        public string Boyadovizkod { get; set; }
        public double Boyayogunlugu { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
