﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymPrzestojPriorytet
{
    public int? PrprzRowId { get; set; }

    public int PrprzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int PrprzZrodgid { get; set; }

    public string PrprzOrgId { get; set; } = null!;

    public string PrprzDirtyOrgId { get; set; } = null!;

    public string PrprzNazwa { get; set; } = null!;

    public string? PrprzOpis { get; set; }

    public string? PrprzParDirtyOrgId { get; set; }

    public string? PrprzParCleanOrgId { get; set; }

    public int? PrprzParGid { get; set; }

    public DateTime PrprzTsinsert { get; set; }

    public DateTime PrprzTsupdate { get; set; }

    public DateTime PrprzTimeFrom { get; set; }

    public DateTime? PrprzTimeTo { get; set; }

    public int PrprzChecksumKimball1 { get; set; }

    public int PrprzChecksumKimball2 { get; set; }

    public int PrprzUpdateSubTransformationId { get; set; }

    public int? PrprzUpdateTransformationId { get; set; }

    public int PrprzInsertSubTransformationId { get; set; }

    public int? PrprzInsertTransformationId { get; set; }

    public byte[] PrprzRowVersion { get; set; } = null!;
}
