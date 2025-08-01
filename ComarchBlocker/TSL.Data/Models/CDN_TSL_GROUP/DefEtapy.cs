﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DefEtapy
{
    public int DetDetId { get; set; }

    public int DetTyp { get; set; }

    public int? DetLp { get; set; }

    public string DetKod { get; set; } = null!;

    public string DetOpis { get; set; } = null!;

    public byte DetCzyData { get; set; }
}
