using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSikayetTutar
    {
        public int Sikayettutarid { get; set; }
        public int Sikayetno { get; set; }
        public string Aciklama { get; set; }
        public double Tutar { get; set; }
    }
}
