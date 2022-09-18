using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaKart
    {
        public string Makinakodu { get; set; }
        public string Makinaadi { get; set; }
        public double Maksboy { get; set; }
        public double Minboy { get; set; }
        public double Maksen { get; set; }
        public double Minen { get; set; }
        public short Makinaek { get; set; }
        public double Genelgiderpayi { get; set; }
        public double Iscilikgideri { get; set; }
        public double Elektrikgideri { get; set; }
        public double Giderkatsayisi { get; set; }
        public double Saatucret { get; set; }
        public double Setup { get; set; }
        public double Setupfire { get; set; }
        public double Yuzdefire { get; set; }
        public string Durumkod { get; set; }
        public bool? Aktif { get; set; }
        public byte Uretimplanlamaadet { get; set; }
        public byte Planlamasirasi { get; set; }
        public bool Kkontrol { get; set; }
        public short Bakiunitesi { get; set; }
        public string Anaislemkod { get; set; }
        public double Gidersaatucret { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
