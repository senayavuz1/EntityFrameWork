using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelKart
    {
        public string Personelkodu { get; set; }
        public bool? Aktif { get; set; }
        public bool? Calisiyor { get; set; }
        public string Grup { get; set; }
        public bool Doviz { get; set; }
        public string Grafikyetkili { get; set; }
        public string Makinaadi { get; set; }
        public string Oturumadi { get; set; }
        public bool Sifregir { get; set; }
        public bool Hizligir { get; set; }
        public string Saonay { get; set; }
        public string Saonay2 { get; set; }
        public string Firmatemsilcisiatama { get; set; }
        public string Personelgrupkod { get; set; }
        public string Unvan { get; set; }
        public string Sifre2 { get; set; }
        public DateTime? Baslatarih { get; set; }
        public string Sosyalno { get; set; }
        public DateTime? Dogumtarih { get; set; }
        public string Dogumyeri { get; set; }
        public string Medeni { get; set; }
        public string Askerlik { get; set; }
        public string Ehliyet { get; set; }
        public string Kan { get; set; }
        public string Adres { get; set; }
        public string Ceptelefon { get; set; }
        public string Telefon { get; set; }
        public string Telefon2 { get; set; }
        public string Saglik { get; set; }
        public string Aciklama { get; set; }
        public string Ilkogretim { get; set; }
        public string Ilkyil { get; set; }
        public string Lise { get; set; }
        public string Liseyil { get; set; }
        public string Yuksekokul { get; set; }
        public string Yuksekyil { get; set; }
        public string Lisansustu { get; set; }
        public string Lisansustuyil { get; set; }
        public DateTime? Oryantasyontarih { get; set; }
        public string Oryantasyonkisi { get; set; }
        public bool Nitelik { get; set; }
        public DateTime? Niteliktarih { get; set; }
        public string Niteliknot { get; set; }
        public string Foto { get; set; }
        public string Eposta { get; set; }
        public string Beden { get; set; }
        public string Ayakno { get; set; }
        public byte Cocuk { get; set; }
        public double Maas { get; set; }
        public string Bolum { get; set; }
        public int Izingun { get; set; }
        public int Izinpotansiyel { get; set; }
        public string Servis { get; set; }
        public short FirmId { get; set; }
        public DateTime? Cikistarih { get; set; }
    }
}
