using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ViewReportCardResultsEdmonton
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Division { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Year { get; set; }

    [Column("ApVendorID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ApVendorId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Supplier { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Employee { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    public int? Rating { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? RatingPercent { get; set; }

    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Cellular { get; set; }
}
