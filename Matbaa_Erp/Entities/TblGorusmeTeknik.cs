using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblGorusmeTeknik
    {
        public int Teknikno { get; set; }
        public string Urunadi { get; set; }
        public string Musterikod { get; set; }
        public string Nasilyapis { get; set; }
        public string Rulotabaka { get; set; }
        public short Iccap { get; set; }
        public short Discap { get; set; }
        public int Bobindeadet { get; set; }
        public string Akisyonu { get; set; }
        public double Tekebadboy { get; set; }
        public double Tekebaden { get; set; }
        public double Aabosluk { get; set; }
        public double Tasiyicien { get; set; }
        public double Radus { get; set; }
        public string Urunkod { get; set; }
        public string Malzemeadi { get; set; }
        public string Yapiskan { get; set; }
        public string Yapiskanadi { get; set; }
        public bool Baskili { get; set; }
        public bool Serigafi { get; set; }
        public bool Trignomi { get; set; }
        public bool Cifttaraf { get; set; }
        public bool Lak { get; set; }
        public string Yuzey { get; set; }
        public string Aylikkulanim { get; set; }
        public string Ambalaj { get; set; }
        public string Koliadet { get; set; }
        public string Ambalajnot { get; set; }
        public string Aciklama { get; set; }
        public string Rafomru { get; set; }
        public bool Degiskenbaski { get; set; }
        public string Baskiadi { get; set; }
        public string Ozelsart { get; set; }
        public string Bicak { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
    }
}
