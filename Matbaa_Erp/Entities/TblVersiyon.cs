using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblVersiyon
    {
        public int VersiyonId { get; set; }
        public string VersiyonAd { get; set; }
        public short Versiyonmajor { get; set; }
        public short Versiyonminor { get; set; }
        public short Versiyonrevize { get; set; }
        public DateTime Versiyontarih { get; set; }
        public string Versiyonaciklama { get; set; }
    }
}
