﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktPracownikUmowyKwoty
{
    public int UstId { get; set; }

    public int UstPerspektywaId { get; set; }

    public int UstUdkid { get; set; }

    public decimal? UstDniDoKonca { get; set; }

    public int UstCzddogid { get; set; }

    public decimal? UstMpodwyzka { get; set; }

    public decimal? UstMstawka { get; set; }

    public int UstPumgid { get; set; }

    public int? UstStrFrmGid { get; set; }

    public int? UstPrcGid { get; set; }

    public int UstBudzetGid { get; set; }

    public int UstAlokacjaGid { get; set; }

    public int? UstInsertTransformationId { get; set; }

    public int UstInsertSubTransformationId { get; set; }

    public int? UstUpdateTransformationId { get; set; }

    public int UstUpdateSubTransformationId { get; set; }

    public DateTime UstTsupdate { get; set; }

    public DateTime UstTsinsert { get; set; }

    public string? UstOpis { get; set; }

    public string UstDirtyOrgId { get; set; } = null!;

    public string UstOrgId { get; set; } = null!;

    public int UstZrodgid { get; set; }

    public int UstCzdgid { get; set; }
}
