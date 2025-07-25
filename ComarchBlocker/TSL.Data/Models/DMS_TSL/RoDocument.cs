﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RoDocument
{
    public int DfhId { get; set; }

    public int DshId { get; set; }

    public int DwdId { get; set; }

    public string? DwdFullNumber { get; set; }

    public int? DwdNumber { get; set; }

    public DateTime DwdCreateDate { get; set; }

    public int? DwdMonth { get; set; }

    public int? DwdYear { get; set; }

    public int DwdDcdownerId { get; set; }
}
