﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymObraz
{
    public int ObrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ObrRowId { get; set; }

    public int? ObrKompresja { get; set; }

    public int? ObrDaneBinarneId { get; set; }

    public long? ObrObrazTimeStamp { get; set; }

    public byte[]? ObrDaneBinarne { get; set; }

    public byte[] ObrRowVersion { get; set; } = null!;

    public int? ObrInsertSubTransformationId { get; set; }

    public int ObrInsertTransformationId { get; set; }

    public int? ObrUpdateSubTransformationId { get; set; }

    public int ObrUpdateTransformationId { get; set; }

    public int ObrChecksumKimball2 { get; set; }

    public int ObrChecksumKimball1 { get; set; }

    public DateTime? ObrTimeTo { get; set; }

    public DateTime ObrTimeFrom { get; set; }

    public DateTime ObrTsupdate { get; set; }

    public DateTime ObrTsinsert { get; set; }

    public int? ObrParGid { get; set; }

    public string? ObrParCleanOrgId { get; set; }

    public string? ObrParDirtyOrgId { get; set; }

    public string? ObrOpis { get; set; }

    public string ObrNazwa { get; set; } = null!;

    public string ObrDirtyOrgId { get; set; } = null!;

    public string ObrOrgId { get; set; } = null!;

    public int ObrZrodgid { get; set; }
}
