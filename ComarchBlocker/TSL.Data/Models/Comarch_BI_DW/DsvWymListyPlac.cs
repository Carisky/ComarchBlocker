﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymListyPlac
{
    public int LplChecksumKimball1 { get; set; }

    public int LplChecksumKimball2 { get; set; }

    public string LplDirtyOrgId { get; set; } = null!;

    public string? LplElementWyplaty { get; set; }

    public int LplId { get; set; }

    public int LplInsertSubTransformationId { get; set; }

    public int? LplInsertTransformationId { get; set; }

    public string? LplListaPlac { get; set; }

    public string? LplNazwa { get; set; }

    public string? LplOpis { get; set; }

    public string LplOrgId { get; set; } = null!;

    public string? LplParCleanOrgId { get; set; }

    public string? LplParDirtyOrgId { get; set; }

    public int? LplParGid { get; set; }

    public int? LplRowId { get; set; }

    public byte[] LplRowVersion { get; set; } = null!;

    public DateTime LplTimeFrom { get; set; }

    public DateTime? LplTimeTo { get; set; }

    public DateTime LplTsinsert { get; set; }

    public DateTime LplTsupdate { get; set; }

    public string? LplTypWyplaty { get; set; }

    public int LplUpdateSubTransformationId { get; set; }

    public int? LplUpdateTransformationId { get; set; }

    public string? LplWyplata { get; set; }

    public int LplZrodgid { get; set; }
}
