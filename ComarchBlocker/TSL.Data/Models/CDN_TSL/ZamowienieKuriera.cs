﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class ZamowienieKuriera
{
    public int ZamkZamkid { get; set; }

    public int ZamkAdresId { get; set; }

    public int ZamkKurierTyp { get; set; }

    public DateTime ZamkDataZamowienia { get; set; }
}
