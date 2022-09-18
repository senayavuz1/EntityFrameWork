using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKonsinye
    {
        public int Konsinyeno { get; set; }
        public DateTime Tarih { get; set; }
        public string Firmakod { get; set; }
        public string Urunkod { get; set; }
        public int? Siparisno { get; set; }
        public int? Sevkiyatno { get; set; }
        public string Irsaliyeno { get; set; }
        public int? Koliadet { get; set; }
        public int? Ruloadet { get; set; }
        public string Urunadet { get; set; }
        public double? Toplamadet { get; set; }
        public double? Sevkfiyat { get; set; }
        public string Faturano { get; set; }
        public int? Faturakoliadet { get; set; }
        public int? Faturaruloadet { get; set; }
        public string Faturaurunadet { get; set; }
        public double? Faturatoplamadet { get; set; }
        public double? Faturafiyat { get; set; }
        public string Faturadovizkod { get; set; }
        public double? Nettoplamadet { get; set; }
        public double? Iadeadet { get; set; }
        public double? Geriiadeadet { get; set; }
        public string Iadeirsaliyeno { get; set; }
        public int? Sikayetno { get; set; }
        public string Iadenot { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
