﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntPromocje
{
    public int KprId { get; set; }

    public int? KprPrmId { get; set; }

    public short? KprKntTyp { get; set; }

    public int? KprKntFirma { get; set; }

    public int? KprKntNumer { get; set; }

    public short? KprKntLp { get; set; }

    public short? KprKngTyp { get; set; }

    public int? KprKngFirma { get; set; }

    public int? KprKngNumer { get; set; }

    public short? KprKngLp { get; set; }

    public int? KprTyp { get; set; }

    public decimal? KprWartosc { get; set; }

    public int? KprOkresTransakcjiOd { get; set; }

    public int? KprOkresTransakcjiDo { get; set; }

    public decimal? KprPunkty { get; set; }

    public string? KprGuid { get; set; }

    public virtual PrmKarty? KprPrm { get; set; }
}
