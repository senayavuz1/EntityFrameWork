using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDegisen
    {
        public long Degisenid { get; set; }
        public string Firmakod { get; set; }
        public string Bagla { get; set; }
        public string Degisenbolum { get; set; }
        public string Degisenalan { get; set; }
        public string Degisenveri { get; set; }
        public string Yeniveri { get; set; }
        public string Desigtirenadisoyadi { get; set; }
        public DateTime Degistirmetarihi { get; set; }
    }
}
