﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymTrasa
{
    public int TraId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? TraRowId { get; set; }

    public string? TraKod { get; set; }

    public string? TraLokalizacja { get; set; }

    public byte[] TraRowVersion { get; set; } = null!;

    public int? TraInsertSubTransformationId { get; set; }

    public int TraInsertTransformationId { get; set; }

    public int? TraUpdateSubTransformationId { get; set; }

    public int TraUpdateTransformationId { get; set; }

    public int TraChecksumKimball2 { get; set; }

    public int TraChecksumKimball1 { get; set; }

    public DateTime? TraTimeTo { get; set; }

    public DateTime TraTimeFrom { get; set; }

    public DateTime TraTsupdate { get; set; }

    public DateTime TraTsinsert { get; set; }

    public int? TraParGid { get; set; }

    public string? TraParCleanOrgId { get; set; }

    public string? TraParDirtyOrgId { get; set; }

    public string? TraOpis { get; set; }

    public string? TraNazwa { get; set; }

    public string TraDirtyOrgId { get; set; } = null!;

    public string TraOrgId { get; set; } = null!;

    public int TraZrodgid { get; set; }
}
