﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoKompZakre
{
    public int OkzOsKid { get; set; }

    public int OkzZakres { get; set; }

    public int? OkzStopienZnajomosci { get; set; }

    public byte? OkzWymagane { get; set; }
}
