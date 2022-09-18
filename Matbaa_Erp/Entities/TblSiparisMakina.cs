using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSiparisMakina
    {
        public long Siparismakinaid { get; set; }
        public int Siparisno { get; set; }
        public string Makinakodu { get; set; }
        public short Sira { get; set; }
        public int Siralama { get; set; }
        public short Ekgecis { get; set; }
        public bool Bitti { get; set; }
        public DateTime? Plantarih { get; set; }
        public int Topsetupsure { get; set; }
        public double Topislemsure { get; set; }
        public double Islemmiktar { get; set; }
        public bool Aktif { get; set; }
        public bool Sirada { get; set; }
        public string Makinabirimkod { get; set; }
        public string Uretimnotu { get; set; }
        public bool Uretimplanlama { get; set; }
        public string Uretimtakip { get; set; }
        public DateTime? Bitistarihi { get; set; }
        public string Bitiren { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
    }
}
