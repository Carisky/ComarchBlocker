﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TrSblad
{
    public int TrSbladTwrId { get; set; }

    public string TrSbladKod { get; set; } = null!;

    public decimal TrSbladIlosc { get; set; }
}
