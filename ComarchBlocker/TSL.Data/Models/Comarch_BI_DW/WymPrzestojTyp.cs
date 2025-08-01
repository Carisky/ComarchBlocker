﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Wymiar posiada dwa wpisy: planowany, nieplanowany.
/// </summary>
public partial class WymPrzestojTyp
{
    public int TprzRowId { get; set; }

    public int TprzId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int TprzZrodgid { get; set; }

    public string TprzOrgId { get; set; } = null!;

    public string TprzDirtyOrgId { get; set; } = null!;

    public string TprzNazwa { get; set; } = null!;

    public string? TprzOpis { get; set; }

    public string? TprzParDirtyOrgId { get; set; }

    public string? TprzParCleanOrgId { get; set; }

    public int? TprzParGid { get; set; }

    public DateTime TprzTsinsert { get; set; }

    public DateTime TprzTsupdate { get; set; }

    public DateTime TprzTimeFrom { get; set; }

    public DateTime? TprzTimeTo { get; set; }

    public int TprzChecksumKimball1 { get; set; }

    public int TprzChecksumKimball2 { get; set; }

    public int TprzUpdateSubTransformationId { get; set; }

    public int? TprzUpdateTransformationId { get; set; }

    public int TprzInsertSubTransformationId { get; set; }

    public int? TprzInsertTransformationId { get; set; }

    public byte[] TprzRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych TprzZrodg { get; set; } = null!;
}
