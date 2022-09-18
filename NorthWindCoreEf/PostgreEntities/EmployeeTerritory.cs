﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWindCoreEf.PostgreEntities
{
    public partial class EmployeeTerritory
    {
        public short EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
