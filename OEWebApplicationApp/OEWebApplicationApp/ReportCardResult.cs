using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ReportCardResult
{
    [Column("ID")]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Division { get; set; }

    [Column("APVendorID")]
    [Unicode(false)]
    public string? ApvendorId { get; set; }

    [Unicode(false)]
    public string? ReportCardYear { get; set; }

    [Unicode(false)]
    public string? Supplier { get; set; }

    [Unicode(false)]
    public string? Employee { get; set; }

    [Column(TypeName = "decimal(4, 2)")]
    public decimal? Rating { get; set; }

    [Unicode(false)]
    public string? Comments { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DateLoaded { get; set; }
}
