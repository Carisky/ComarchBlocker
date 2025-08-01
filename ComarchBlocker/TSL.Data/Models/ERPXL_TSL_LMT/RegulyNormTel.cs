﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RegulyNormTel
{
    public int RntelId { get; set; }

    public string? RntelOpTelOrgId { get; set; }

    public string? RntelTypZmiany { get; set; }

    public string? RntelZmianaZ { get; set; }

    public string? RntelZmianaNa { get; set; }

    public string? RntelWarunekSql { get; set; }

    public virtual OperatorTel? RntelOpTelOrg { get; set; }
}
