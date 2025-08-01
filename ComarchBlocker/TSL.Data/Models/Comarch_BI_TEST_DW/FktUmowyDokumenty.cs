﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktUmowyDokumenty
{
    public int UdoDokNumerId { get; set; }

    public int UdoUmnid { get; set; }

    public int UdoId { get; set; }

    public int UdoZrodgid { get; set; }

    public int UdoCzdid { get; set; }

    public string UdoOrgId { get; set; } = null!;

    public string UdoDirtyOrgId { get; set; } = null!;

    public string? UdoOpis { get; set; }

    public DateTime UdoTsinsert { get; set; }

    public DateTime UdoTsupdate { get; set; }

    public int? UdoUpdateSubTransformationId { get; set; }

    public int? UdoUpdateTransformationId { get; set; }

    public int? UdoInsertSubTransformationId { get; set; }

    public int? UdoInsertTransformationId { get; set; }

    public virtual WymCzasDzien UdoCzd { get; set; } = null!;

    public virtual WymDokumentNumer UdoDokNumer { get; set; } = null!;

    public virtual WymUmowa UdoUmn { get; set; } = null!;

    public virtual WymZrodloDanych UdoZrodg { get; set; } = null!;
}
