using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBaskiTipDetay
    {
        public long BaskitipaltId { get; set; }
        public string Baskitipkod { get; set; }
        public int Mamultipkod { get; set; }
        public double Azyogunluk { get; set; }
        public double Cokyogunluk { get; set; }
    }
}
