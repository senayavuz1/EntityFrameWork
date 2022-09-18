using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirma
    {
        public TblFirma()
        {
            TblFirmaFirmas = new HashSet<TblFirmaFirma>();
            TblFirmaGorusmelers = new HashSet<TblFirmaGorusmeler>();
            TblFirmaTeslimats = new HashSet<TblFirmaTeslimat>();
        }

        public string Tip { get; set; }
        public string Statu { get; set; }
        public string Firmakod { get; set; }
        public string Ozelkod { get; set; }
        public string Kisaad { get; set; }
        public string Ticariad { get; set; }
        public string Faturaadres1 { get; set; }
        public string Faturaadres2 { get; set; }
        public string Postakod { get; set; }
        public string Ilcekod { get; set; }
        public string Ilkod { get; set; }
        public string Ulkekod { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Faks1 { get; set; }
        public string Faks2 { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public string Muhasebekod { get; set; }
        public string Muhasebekodsatis { get; set; }
        public string Sektorkod { get; set; }
        public string Sektoraltkod { get; set; }
        public string Grupkod { get; set; }
        public string Vergidairesi { get; set; }
        public string Vergino { get; set; }
        public string Odemesekli { get; set; }
        public string Personelkodu { get; set; }
        public string Personelkodu2 { get; set; }
        public string Grafikperskod { get; set; }
        public double Risklimiti { get; set; }
        public string Parabirimi { get; set; }
        public string Parabirimicari { get; set; }
        public string Durumfirmakod { get; set; }
        public DateTime? Sonaktiftarih { get; set; }
        public string Ozelnot { get; set; }
        public string Irsaliyenot { get; set; }
        public string Faturanot { get; set; }
        public bool Istihbaratonay { get; set; }
        public string Istihbaratnot { get; set; }
        public string Istihbaratpersonelkod { get; set; }
        public string Tckimlikno { get; set; }
        public bool Sorunlu { get; set; }
        public string Sorunnot { get; set; }
        public double Valor { get; set; }
        public string Odemekod { get; set; }
        public string Sevkiyatkod { get; set; }
        public short Sevklimit { get; set; }
        public short Kalitefiyat { get; set; }
        public short Kaliteiletisim { get; set; }
        public DateTime? Ilksiparistarihi { get; set; }
        public string Ilksiparispersonel { get; set; }
        public DateTime? Sonsiparistarihi { get; set; }
        public DateTime? Soniletisimtarihi { get; set; }
        public string Faturatipi { get; set; }
        public double Sabitkur { get; set; }
        public byte Yuvarlama { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
        public int? SekId { get; set; }

        public virtual TblSektor Sek { get; set; }
        public virtual TblUlke UlkekodNavigation { get; set; }
        public virtual ICollection<TblFirmaFirma> TblFirmaFirmas { get; set; }
        public virtual ICollection<TblFirmaGorusmeler> TblFirmaGorusmelers { get; set; }
        public virtual ICollection<TblFirmaTeslimat> TblFirmaTeslimats { get; set; }
    }
}
