﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PrcWarunki
{
    public short? PrwGidtyp { get; set; }

    public int? PrwGidfirma { get; set; }

    public int PrwGidnumer { get; set; }

    public short PrwGidlp { get; set; }

    public byte? PrwTyp { get; set; }

    public int? PrwWmrId { get; set; }

    public string? PrwTypWymiaru { get; set; }

    public virtual PrcKarty PrwGidnumerNavigation { get; set; } = null!;
}
