using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSevkAlt
    {
        public long Satirno { get; set; }
        public long Sevkno { get; set; }
        public byte Sirano { get; set; }
        public int Siparisno { get; set; }
        public string Musterisano { get; set; }
        public string Urunkod { get; set; }
        public short Urunno { get; set; }
        public string Birimkod { get; set; }
        public int Sevkiyatno { get; set; }
        public string Stokkod { get; set; }
        public long Urunsevkdetayid { get; set; }
        public int Koliadet { get; set; }
        public int Ruloadet { get; set; }
        public string Urunadet { get; set; }
        public double Toplamadet { get; set; }
        public double Siparisfiyat { get; set; }
        public string Siparisdovizkod { get; set; }
        public double Kur { get; set; }
        public double Sabitkur { get; set; }
        public string Dovizalissatis { get; set; }
        public double Faturafiyat { get; set; }
        public double Iskontoyuzde { get; set; }
        public double Iskontotutar { get; set; }
        public double Tutar { get; set; }
        public double Kdv { get; set; }
        public double Kdvtutar { get; set; }
        public double Kdvlitutar { get; set; }
        public string Aciklama { get; set; }
        public bool Onaysiz { get; set; }
    }
}
