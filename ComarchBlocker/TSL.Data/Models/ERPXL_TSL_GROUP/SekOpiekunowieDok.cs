﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SekOpiekunowieDok
{
    public int SodId { get; set; }

    public short? SodOpiekunGidTyp { get; set; }

    public int? SodOpiekunGidNumer { get; set; }

    public int? SodSosId { get; set; }

    public virtual SekStatusyDok? SodSos { get; set; }
}
