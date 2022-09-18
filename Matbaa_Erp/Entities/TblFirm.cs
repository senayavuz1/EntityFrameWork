using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirm
    {
        public TblFirm()
        {
            TblFirmaFirmas = new HashSet<TblFirmaFirma>();
        }

        public short FirmId { get; set; }
        public string FirmAd { get; set; }

        public virtual ICollection<TblFirmaFirma> TblFirmaFirmas { get; set; }
    }
}
