﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymOperator
{
    public int OpeId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? OpeRowId { get; set; }

    public string? OpeSkrot { get; set; }

    public byte[] OpeRowVersion { get; set; } = null!;

    public int? OpeInsertSubTransformationId { get; set; }

    public int OpeInsertTransformationId { get; set; }

    public int? OpeUpdateSubTransformationId { get; set; }

    public int OpeUpdateTransformationId { get; set; }

    public int OpeChecksumKimball2 { get; set; }

    public int OpeChecksumKimball1 { get; set; }

    public DateTime? OpeTimeTo { get; set; }

    public DateTime OpeTimeFrom { get; set; }

    public DateTime OpeTsupdate { get; set; }

    public DateTime OpeTsinsert { get; set; }

    public int? OpeParGid { get; set; }

    public string? OpeParCleanOrgId { get; set; }

    public string? OpeParDirtyOrgId { get; set; }

    public string? OpeOpis { get; set; }

    public string OpeNazwa { get; set; } = null!;

    public string OpeDirtyOrgId { get; set; } = null!;

    public string OpeOrgId { get; set; } = null!;

    public int OpeZrodgid { get; set; }

    public int? OpePrcId { get; set; }
}
