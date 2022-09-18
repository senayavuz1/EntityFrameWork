using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWindCoreEf.Entities
{
    public partial class UrunlereGoreDagilim
    {
        public string ProductName { get; set; }
        public int? Adet { get; set; }
        public double? Ciro { get; set; }
    }
}
