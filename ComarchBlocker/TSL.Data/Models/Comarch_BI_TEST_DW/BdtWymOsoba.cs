﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymOsoba
{
    public int OsoId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? OsoRowId { get; set; }

    public string? OsoKomorka { get; set; }

    public string? OsoFax { get; set; }

    public string? OsoEmail { get; set; }

    public string? OsoTelefon { get; set; }

    public string? OsoStanowisko { get; set; }

    public string? OsoDzial { get; set; }

    public byte[] OsoRowVersion { get; set; } = null!;

    public int? OsoInsertSubTransformationId { get; set; }

    public int OsoInsertTransformationId { get; set; }

    public int? OsoUpdateSubTransformationId { get; set; }

    public int OsoUpdateTransformationId { get; set; }

    public int OsoChecksumKimball2 { get; set; }

    public int OsoChecksumKimball1 { get; set; }

    public DateTime? OsoTimeTo { get; set; }

    public DateTime OsoTimeFrom { get; set; }

    public DateTime OsoTsupdate { get; set; }

    public DateTime OsoTsinsert { get; set; }

    public int? OsoParGid { get; set; }

    public string? OsoParCleanOrgId { get; set; }

    public string? OsoParDirtyOrgId { get; set; }

    public string? OsoTytul { get; set; }

    public string? OsoNazwa { get; set; }

    public string OsoDirtyOrgId { get; set; } = null!;

    public string OsoCleanOrgId { get; set; } = null!;

    public int OsoZrodgid { get; set; }
}
