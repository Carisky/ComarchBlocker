﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KsefCode
{
    public int Id { get; set; }

    public string License { get; set; } = null!;

    public string Value { get; set; } = null!;
}
