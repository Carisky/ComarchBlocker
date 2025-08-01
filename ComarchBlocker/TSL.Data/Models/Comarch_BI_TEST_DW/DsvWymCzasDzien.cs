﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymCzasDzien
{
    public string CzasPerspektywa { get; set; } = null!;

    public int? CzdAktualneOrgId { get; set; }

    public int? CzdAktualneOrgParId { get; set; }

    public int? CzdAktywny { get; set; }

    public int? CzdCzmid { get; set; }

    public int? CzdCzrid { get; set; }

    public int? CzdCztid { get; set; }

    public int? CzdCztisogid { get; set; }

    public DateTime? CzdData { get; set; }

    public int? CzdDataDo { get; set; }

    public int? CzdDataOd { get; set; }

    public string? CzdDzienKod { get; set; }

    public string? CzdDzienNazwa { get; set; }

    public string? CzdDzienRoku { get; set; }

    public int CzdId { get; set; }

    public int? CzdKimball1CheckSum { get; set; }

    public int? CzdKimball2CheckSum { get; set; }

    public string? CzdKodWtygodniu { get; set; }

    public string? CzdNazwa { get; set; }

    public string? CzdNazwaWtygodniu { get; set; }

    public int? CzdNrMiesiaca { get; set; }

    public int? CzdNrTygodnia { get; set; }

    public int? CzdNrWmiesiacu { get; set; }

    public int? CzdNrWroku { get; set; }

    public int? CzdNrWtygodniu { get; set; }

    public int? CzdNumerWkwartale { get; set; }

    public string? CzdOkresObrach { get; set; }

    public string? CzdOpis { get; set; }

    public string? CzdOrgAtrId { get; set; }

    public int CzdOrgId { get; set; }

    public int? CzdOrgParId { get; set; }

    public int? CzdParId { get; set; }

    public int? CzdPoczatekOkresuObrach { get; set; }

    public int? CzdPoprzednikId { get; set; }

    public string? CzdRoboczy { get; set; }

    public int? CzdRowId { get; set; }

    public byte[] CzdRowVersion { get; set; } = null!;

    public DateTime CzdTsinsert { get; set; }

    public DateTime CzdTsupdate { get; set; }

    public int? CzdTydzienNazwaIso { get; set; }

    public int? CzdWymFirma { get; set; }

    public int? CzdWymTyp { get; set; }

    public int? OrderDzienRoku { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
