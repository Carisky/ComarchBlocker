﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPracownikEtatyLpracownikow
{
    public int EttAlokacjaGid { get; set; }

    public int EttBudzetGid { get; set; }

    public int EttId { get; set; }

    public int EttCzdgid { get; set; }

    public int EttZrodgid { get; set; }

    public string EttOrgId { get; set; } = null!;

    public string EttDirtyOrgId { get; set; } = null!;

    public string? EttOpis { get; set; }

    public DateTime EttTsinsert { get; set; }

    public DateTime EttTsupdate { get; set; }

    public int EttUpdateSubTransformationId { get; set; }

    public int? EttUpdateTransformationId { get; set; }

    public int EttInsertSubTransformationId { get; set; }

    public int? EttInsertTransformationId { get; set; }

    public decimal? EttMetat { get; set; }

    public int EttPumgid { get; set; }

    public int EttPerspektywaId { get; set; }

    public int? EttPrcGid { get; set; }

    public int? EttStrFrmGid { get; set; }

    public int EttPrstid { get; set; }

    public decimal? EttMstaz { get; set; }

    public decimal? EttMstazWartosc { get; set; }

    public decimal? EttMwiek { get; set; }

    public int EttCzdzatrudnieniaId { get; set; }

    public int EttCzdzwolnieniaId { get; set; }

    public int? EttMwiekAktualny { get; set; }

    public decimal? EttMstazAktualny { get; set; }
}
