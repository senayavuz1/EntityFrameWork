using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblPersonelIzinHak
    {
        public int Izinid { get; set; }
        public string Personelkodu { get; set; }
        public DateTime Ilktarih { get; set; }
        public DateTime Sontarih { get; set; }
        public short Hakedilen { get; set; }
        public short Kullanilan { get; set; }
        public string Aciklama { get; set; }
        public string Izintakibi { get; set; }
    }
}
