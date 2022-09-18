using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblSektor
    {
        public TblSektor()
        {
            TblFirmas = new HashSet<TblFirma>();
        }

        public string Sektorkod { get; set; }
        public string Sektoraltkod { get; set; }
        public string Sektoranaad { get; set; }
        public string Sektorad { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
        public int SekId { get; set; }

        public virtual ICollection<TblFirma> TblFirmas { get; set; }
    }
}
