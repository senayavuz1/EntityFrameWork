using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBicakIz
    {
        public long BicakizId { get; set; }
        public long BicakId { get; set; }
        public string Bicakiz { get; set; }
        public DateTime Bicakiztarihi { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
