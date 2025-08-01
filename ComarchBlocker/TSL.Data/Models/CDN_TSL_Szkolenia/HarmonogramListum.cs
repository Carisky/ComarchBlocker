﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class HarmonogramListum
{
    public int HrlHrlId { get; set; }

    public int HrlHrmId { get; set; }

    public decimal HrlRataKapitalowa { get; set; }

    public int HrlRok { get; set; }

    public short HrlMiesiac { get; set; }

    public decimal HrlRataOdsetkowa { get; set; }

    public string? HrlImportRowId { get; set; }

    public virtual Harmonogram HrlHrm { get; set; } = null!;
}
