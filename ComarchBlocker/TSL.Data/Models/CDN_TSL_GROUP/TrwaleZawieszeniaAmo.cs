﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TrwaleZawieszeniaAmo
{
    public int SrZaSrZaid { get; set; }

    public int SrZaSrTid { get; set; }

    public int SrZaRokMies { get; set; }

    public byte SrZaTyp { get; set; }

    public virtual Trwale SrZaSrT { get; set; } = null!;
}
