using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSevk
    {
        public long Sevkno { get; set; }
        public string Belgetipi { get; set; }
        public string Durumu { get; set; }
        public string Belgeserino { get; set; }
        public string Belgesirano { get; set; }
        public long Faturasevkno { get; set; }
        public short FirmId { get; set; }
        public string Firmakod { get; set; }
        public string Carikod { get; set; }
        public string Ilgilikod { get; set; }
        public string Subekod { get; set; }
        public string Musterisano { get; set; }
        public string Sevkiyatkod { get; set; }
        public DateTime? Belgetarih { get; set; }
        public DateTime? Sevktarih { get; set; }
        public string Sevkiyatnotu { get; set; }
        public string Aciklama { get; set; }
        public int Konsinyeno { get; set; }
        public short Vade { get; set; }
        public string Belgedovizkod { get; set; }
        public double Faturakur { get; set; }
        public double Iskontoyuzde { get; set; }
        public double Iskontotutar { get; set; }
        public double Toplam { get; set; }
        public double Kdv { get; set; }
        public double Yekun { get; set; }
        public string Yaziyla { get; set; }
        public string Iptal { get; set; }
        public string Sevktipkod { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
