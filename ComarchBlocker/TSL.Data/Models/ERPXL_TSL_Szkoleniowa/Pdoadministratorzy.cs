﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Pdoadministratorzy
{
    public int PdoaId { get; set; }

    public short? PdoaObiTyp { get; set; }

    public int? PdoaObiNumer { get; set; }

    public int? PdoaObiLp { get; set; }

    public int? PdoaAdrNumer { get; set; }

    public byte? PdoaTyp { get; set; }

    public int? PdoaDataDodania { get; set; }
}
