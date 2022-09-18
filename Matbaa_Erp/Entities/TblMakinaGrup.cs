using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblMakinaGrup
    {
        public string Makinagrupkod { get; set; }
        public string Kodaciklama { get; set; }
        public short FirmId { get; set; }
        public string Kalipbilgi { get; set; }
        public short Tanimsira { get; set; }
        public string Adetforma { get; set; }
        public string UretimdeTakipEt { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
