using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUlke
    {
        public TblUlke()
        {
            TblFirmas = new HashSet<TblFirma>();
        }

        public string Ulkekod { get; set; }
        public string Ulkead { get; set; }
        public string UlkeadIngilizce { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }

        public virtual ICollection<TblFirma> TblFirmas { get; set; }
    }
}
