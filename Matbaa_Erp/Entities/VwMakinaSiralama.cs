using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class VwMakinaSiralama
    {
        public string Urunadi { get; set; }
        public string Kisaad { get; set; }
        public string Birimadi { get; set; }
        public string Urunkod { get; set; }
        public string Grafikonay { get; set; }
        public string Musterikod { get; set; }
        public long Siparismakinaid { get; set; }
        public int Siparisno { get; set; }
        public string Makinakodu { get; set; }
        public short Sira { get; set; }
        public int Siralama { get; set; }
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
        public DateTime? Siparistarih { get; set; }
        public string Kodaciklama { get; set; }
        public bool? Ilkdefa { get; set; }
        public string Ilkdefauy { get; set; }
        public bool? Depodan { get; set; }
        public bool? Revizyonvar { get; set; }
        public bool? Eskifilmat { get; set; }
        public bool? Revizyonfilmdegil { get; set; }
        public string Revizyonnot { get; set; }
        public string Irsaliyenot { get; set; }
        public string Faturanot { get; set; }
        public string Bicakdurum { get; set; }
        public string Klisedurum { get; set; }
        public string Malzemedurum { get; set; }
        public string Mamultipadi { get; set; }
        public string Temsilci { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
        public DateTime? Planlamatermintarihi { get; set; }
        public DateTime? Planlamakabultarihi { get; set; }
        public string Kliseno { get; set; }
        public string Makinaadi { get; set; }
        public string Firmakod { get; set; }
        public bool? Prova { get; set; }
        public short Ekgecis { get; set; }
        public string Bicakkodu { get; set; }
    }
}
