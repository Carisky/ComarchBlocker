﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class CrmakcjeDokumenty
{
    public int CadCaaid { get; set; }

    public short CadDokTyp { get; set; }

    public virtual CrmakcjeAutomatyczne CadCaa { get; set; } = null!;
}
