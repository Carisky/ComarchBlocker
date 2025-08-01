﻿using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymZamowieniaStan
{
    public int ZamStanZamTypId { get; set; }

    public int ZamStanRowId { get; set; }

    public int ZamStanId { get; set; }

    public int ZamStanZrodgid { get; set; }

    public string ZamStanOrgId { get; set; } = null!;

    public string ZamStanDirtyOrgId { get; set; } = null!;

    public string ZamStanNazwa { get; set; } = null!;

    public string? ZamStanOpis { get; set; }

    public string? ZamStanParDirtyOrgId { get; set; }

    public string? ZamStanParCleanOrgId { get; set; }

    public int? ZamStanParGid { get; set; }

    public DateTime ZamStanTsinsert { get; set; }

    public DateTime ZamStanTsupdate { get; set; }

    public DateTime ZamStanTimeFrom { get; set; }

    public DateTime? ZamStanTimeTo { get; set; }

    public int? ZamStanChecksumKimball1 { get; set; }

    public int? ZamStanChecksumKimball2 { get; set; }

    public int? ZamStanUpdateTransformationId { get; set; }

    public int? ZamStanUpdateSubTransformationId { get; set; }

    public int? ZamStanInsertTransformationId { get; set; }

    public int? ZamStanInsertSubTransformationId { get; set; }

    public byte[] ZamStanRowVersion { get; set; } = null!;

    public int? ZamStanOd { get; set; }

    public int? ZamStanDo { get; set; }

    public string? ZamStanTypOrgId { get; set; }

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymZapadalnoscTyp ZamStanZamTyp { get; set; } = null!;

    public virtual WymZrodloDanych ZamStanZrodg { get; set; } = null!;
}
