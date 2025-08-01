﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymStanZamowienium
{
    public int StzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? StzRowId { get; set; }

    public string? StzOpis { get; set; }

    public string StzNazwa { get; set; } = null!;

    public string StzAktualneOrgId { get; set; } = null!;

    public int StzZrodgid { get; set; }

    public int StzUpdateTransformationId { get; set; }

    public int? StzUpdateSubTransformationId { get; set; }

    public DateTime StzTsupdate { get; set; }

    public DateTime StzTsinsert { get; set; }

    public DateTime? StzTimeTo { get; set; }

    public DateTime StzTimeFrom { get; set; }

    public byte[] StzRowVersion { get; set; } = null!;

    public int? StzParGid { get; set; }

    public string? StzParDirtyOrgId { get; set; }

    public string? StzParCleanOrgId { get; set; }

    public string StzOrgId { get; set; } = null!;

    public int StzInsertTransformationId { get; set; }

    public int? StzInsertSubTransformationId { get; set; }

    public string StzDirtyOrgId { get; set; } = null!;

    public int StzChecksumKimball2 { get; set; }

    public int StzChecksumKimball1 { get; set; }
}
