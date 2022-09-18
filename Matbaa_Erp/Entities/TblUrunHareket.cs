using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunHareket
    {
        public long Hareketid { get; set; }
        public int Hareketno { get; set; }
        public string Stokkod { get; set; }
        public string Urunkod { get; set; }
        public string Harekettipkod { get; set; }
        public DateTime? Cikistarih { get; set; }
        public double Cikismiktar1 { get; set; }
        public double Cikismiktar2 { get; set; }
        public int Cikistabaka { get; set; }
        public double Netcikis { get; set; }
        public DateTime? Giristarih { get; set; }
        public double Girismiktar1 { get; set; }
        public double Girismiktar2 { get; set; }
        public int Giristabaka { get; set; }
        public double Netgiris { get; set; }
        public bool Muadil { get; set; }
        public string Muadilurunkod { get; set; }
        public string Fisno { get; set; }
        public string Irsaliyeno { get; set; }
        public DateTime? Irsaliyetarih { get; set; }
        public string Aciklama { get; set; }
        public int Revizesiparisno { get; set; }
        public bool Kullanildi { get; set; }
        public long Belgeno { get; set; }
        public long Terminno { get; set; }
        public long Said { get; set; }
        public int Sasiparisno { get; set; }
        public string Sira { get; set; }
        public int Teslimno { get; set; }
        public int Sevkiyatno { get; set; }
        public short Yyadet { get; set; }
        public double Idealen { get; set; }
        public long Satirdetayid { get; set; }
        public long Sipihtiyacid { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
