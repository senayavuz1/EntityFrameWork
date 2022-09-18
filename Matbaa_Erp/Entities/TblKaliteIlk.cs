using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblKaliteIlk
    {
        public long Kaliteilkid { get; set; }
        public DateTime? Tarih { get; set; }
        public long Teslimno { get; set; }
        public string Ambalajbutunluk { get; set; }
        public string Sevkaraci { get; set; }
        public string Paletuygunluk { get; set; }
        public string Etiketkontrolu { get; set; }
        public string Bobinsarimyonu { get; set; }
        public string Korona { get; set; }
        public string Yapisma { get; set; }
        public string Cekmekontrolu { get; set; }
        public string Olcukontrolu { get; set; }
        public string Analizsertifikasi { get; set; }
        public string Mikronkontolu { get; set; }
        public string Kabuldurumu { get; set; }
        public string Kontoleden { get; set; }
        public string Onayliyan { get; set; }
    }
}
