using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunRevizyon
    {
        public string Urunkod { get; set; }
        public string Revizyonkod { get; set; }
        public string Alan { get; set; }
        public string Eskiveri { get; set; }
        public string Yeniveri { get; set; }
        public string Desigtirenadisoyadi { get; set; }
        public DateTime Degistirmetarihi { get; set; }
    }
}
