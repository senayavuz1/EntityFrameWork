using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblBirim
    {
        public string Birimkod { get; set; }
        public string Kodaciklama { get; set; }
        public string Birimtip { get; set; }
        public double Oran { get; set; }
        public string Simge { get; set; }
        public string Teklifbirimikullan { get; set; }
        public string Kodaciklamaing { get; set; }
        public string Simgeing { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
