using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblFirmaTeslimatEtiket
    {
        public int FirmaEtiketId { get; set; }
        public string Firmakod { get; set; }
        public string Subekod { get; set; }
        public string Etikettipi { get; set; }

        public virtual TblFirmaTeslimat TblFirmaTeslimat { get; set; }
    }
}
