﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class VFktCennik
{
    public int CenDataZakonczeniaId { get; set; }

    public int CenWalutaId { get; set; }

    public int CenDataRozpoczeciaId { get; set; }

    public int CenProdId { get; set; }

    public int CenCennikId { get; set; }

    public int CenId { get; set; }

    public int CenZrodgid { get; set; }

    public int CenCzdid { get; set; }

    public string CenCleanOrgId { get; set; } = null!;

    public string CenDirtyOrgId { get; set; } = null!;

    public string? CenOpis { get; set; }

    public int CenUpdateTransformationId { get; set; }

    public int? CenUpdateSubTransformationId { get; set; }

    public int CenInsertTransformationId { get; set; }

    public int? CenInsertSubTransformationId { get; set; }

    public DateTime CenTsinsert { get; set; }

    public DateTime CenTsupdate { get; set; }

    public decimal? CenMcenaNetto { get; set; }

    public decimal? CenMcenaBrutto { get; set; }

    public int CenKntId { get; set; }

    public int CenOperatorId { get; set; }

    public int CenAlokacjaId { get; set; }

    public int CenPrmgid { get; set; }

    public int CenOpemgid { get; set; }

    public int CenOpezgid { get; set; }

    public int CenOpewgid { get; set; }

    public string? CenOrgAtrId { get; set; }

    public decimal? CenMcenaBruttoCennik { get; set; }

    public decimal? CenMcenaNettoCennik { get; set; }
}
