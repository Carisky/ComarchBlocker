﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class XlSamochody
{
    public int SyncId { get; set; }

    public int Id { get; set; }

    public int Ts { get; set; }

    public byte Akcja { get; set; }
}
