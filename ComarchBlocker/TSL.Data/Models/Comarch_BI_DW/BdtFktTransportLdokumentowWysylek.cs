﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktTransportLdokumentowWysylek
{
    public int TrsId { get; set; }

    public string? TrsOrgAtrNagIdwyp { get; set; }

    public string? TrsOrgAtrNagIdwys { get; set; }

    public int TrsAlokacjaId { get; set; }

    public int? TrsObszar { get; set; }

    public decimal? TrsMdlugoscTrasyRozbita { get; set; }

    public string? TrsOrgAtrId { get; set; }

    public int TrsBudzetId { get; set; }

    public decimal? TrsMkoszt { get; set; }

    public int TrsSamId { get; set; }

    public decimal? TrsMdlugoscTrasy { get; set; }

    public decimal? TrsWagaBrutto { get; set; }

    public decimal? TrsObjetosc { get; set; }

    public int? TrsFlagaKosztu { get; set; }

    public int TrsDokNumerId { get; set; }

    public int TrsDokNumerWysid { get; set; }

    public int TrsTrasaId { get; set; }

    public int TrsKnSid { get; set; }

    public int TrsPrcId { get; set; }

    public int TrsCzddstDoId { get; set; }

    public int TrsCzddstOdId { get; set; }

    public DateTime TrsTsupdate { get; set; }

    public DateTime TrsTsinsert { get; set; }

    public int? TrsInsertSubTransformationId { get; set; }

    public int TrsInsertTransformationId { get; set; }

    public int? TrsUpdateSubTransformationId { get; set; }

    public int TrsUpdateTransformationId { get; set; }

    public string? TrsOpis { get; set; }

    public string TrsDirtyOrgId { get; set; } = null!;

    public string TrsOrgId { get; set; } = null!;

    public int TrsCzdid { get; set; }

    public int TrsZrodgid { get; set; }

    public int TrsCzdwysId { get; set; }

    public decimal? TrsMwysNetto { get; set; }

    public decimal? TrsMwysBrutto { get; set; }

    public int TrsDokZwiazanyId { get; set; }

    public int TrsKntDokZwiazanyId { get; set; }

    public decimal? TrsMiloscTowaru { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public decimal? TrsMiloscPaczek { get; set; }

    public int TrsStrPrwId { get; set; }

    public decimal? TrsWagaNetto { get; set; }

    public int TrsPaczgid { get; set; }

    public int TrsWysygid { get; set; }

    public decimal? TrsMpobranie { get; set; }

    public decimal? TrsMubezpieczenie { get; set; }
}
