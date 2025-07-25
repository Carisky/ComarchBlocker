﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SerwisanciView
{
    public int SrWId { get; set; }

    public int SrWTyp { get; set; }

    public string SrWKod { get; set; } = null!;

    public string SrWNazwisko { get; set; } = null!;

    public string SrWImie { get; set; } = null!;

    public string SrWTelefon { get; set; } = null!;

    public string SrWTelefon2 { get; set; } = null!;
}
