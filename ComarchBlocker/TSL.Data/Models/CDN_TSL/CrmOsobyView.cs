﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class CrmOsobyView
{
    public int Typ { get; set; }

    public int Id { get; set; }

    public string Kod { get; set; } = null!;

    public string? Nazwa { get; set; }

    public int? Nieaktywny { get; set; }
}
