﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktJgospodarczeGu
{
    public int JgoCzdgid { get; set; }

    public string JgoDirtyOrgId { get; set; } = null!;

    public int JgoDzialid { get; set; }

    public int? JgoGeoid { get; set; }

    public decimal? JgoGuspkb { get; set; }

    public int? JgoGustwrGrId { get; set; }

    public int? JgoGustwrId { get; set; }

    public int? JgoGustwrId2 { get; set; }

    public int? JgoGuswynId { get; set; }

    public int JgoId { get; set; }

    public decimal? JgoIlosc { get; set; }

    public int? JgoInsertSubTransformationId { get; set; }

    public int JgoInsertTransformationId { get; set; }

    public int? JgoLugid { get; set; }

    public decimal? JgoMcena { get; set; }

    public decimal? JgoMindexQgp { get; set; }

    public decimal? JgoMindexQgw { get; set; }

    public decimal? JgoMindexQop { get; set; }

    public decimal? JgoMindexQow { get; set; }

    public decimal? JgoMindexRgp { get; set; }

    public decimal? JgoMindexRgw { get; set; }

    public decimal? JgoMindexRop { get; set; }

    public decimal? JgoMindexRow { get; set; }

    public decimal? JgoMwynikFinansowy { get; set; }

    public string? JgoOpis { get; set; }

    public string JgoOrgId { get; set; } = null!;

    public int? JgoPlecId { get; set; }

    public DateTime JgoTsinsert { get; set; }

    public DateTime JgoTsupdate { get; set; }

    public int? JgoUpdateSubTransformationId { get; set; }

    public int JgoUpdateTransformationId { get; set; }

    public int JgoZrodgid { get; set; }
}
