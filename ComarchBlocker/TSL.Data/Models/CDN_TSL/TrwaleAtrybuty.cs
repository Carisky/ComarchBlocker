﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleAtrybuty
{
    public int SrASrAid { get; set; }

    public int? SrADeAid { get; set; }

    public int? SrASrTid { get; set; }

    public int? SrAWypId { get; set; }

    public int? SrATyp { get; set; }

    public string SrAWartoscTxt { get; set; } = null!;

    public virtual DefAtrybuty? SrADeA { get; set; }

    public virtual Trwale? SrASrT { get; set; }
}
