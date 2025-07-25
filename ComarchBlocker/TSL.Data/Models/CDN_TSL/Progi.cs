﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Progi
{
    public int PrgPrgId { get; set; }

    public int PrgPreId { get; set; }

    public decimal PrgKwota { get; set; }

    public decimal PrgProcent { get; set; }

    public string? PrgImportRowId { get; set; }

    public virtual PracEtaty PrgPre { get; set; } = null!;
}
