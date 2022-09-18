using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblUrunAmbalaji
    {
        public string Urunkod { get; set; }
        public float? En { get; set; }
        public float? Boy { get; set; }
        public float? Yuk { get; set; }
        public float? Hacim { get; set; }
        public float? Agirlik { get; set; }
        public float? Miktar { get; set; }
    }
}
