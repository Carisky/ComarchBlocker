﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktPracownikCzasPracy
{
    public int PcpId { get; set; }

    public int PcpZrodgid { get; set; }

    public int PcpCzdgid { get; set; }

    public string PcpOrgId { get; set; } = null!;

    public string PcpDirtyOrgId { get; set; } = null!;

    public int? PcpUpdateTransformationId { get; set; }

    public int PcpUpdateSubTransformationId { get; set; }

    public int? PcpInsertTransformationId { get; set; }

    public int PcpInsertSubTransformationId { get; set; }

    public DateTime PcpTsinsert { get; set; }

    public DateTime PcpTsupdate { get; set; }

    public decimal? PcpMwymiarLiczbaGodzin { get; set; }

    public decimal? PcpMwymiarLiczbaMinut { get; set; }

    public decimal? PcpMwymiarLiczbaDni { get; set; }

    public decimal? PcpMczasLiczbaGodzin { get; set; }

    public decimal? PcpMczasLiczbaMinut { get; set; }

    public decimal? PcpMczasLiczbaDni { get; set; }

    public int PcpAlokacjaGid { get; set; }

    public int PcpBudzetGid { get; set; }

    public int PcpPerspektywaGid { get; set; }

    public int? PcpPrcGid { get; set; }
}
