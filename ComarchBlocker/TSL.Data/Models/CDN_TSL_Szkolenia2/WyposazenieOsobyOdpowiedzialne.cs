﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WyposazenieOsobyOdpowiedzialne
{
    public int WyOoWyOoid { get; set; }

    public int WyOoWypId { get; set; }

    public DateTime? WyOoDataOd { get; set; }

    public DateTime? WyOoDataDo { get; set; }

    public int? WyOoPrcId { get; set; }

    public string WyOoPrcImieNazwisko { get; set; } = null!;

    public virtual Wyposazenie WyOoWyp { get; set; } = null!;
}
