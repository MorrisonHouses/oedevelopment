using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Table("tblCGYOE")]
public partial class TblCgyoe
{
    [Key]
    [Column("RequestID")]
    public int RequestId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RequestedBy { get; set; }

    [Column("GLAccount")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Glaccount { get; set; }

    public int? AutoApproveThreshold { get; set; }

    public double? Amount { get; set; }

    [Column("GSTAmount")]
    public double? Gstamount { get; set; }

    public double? TotalAmount { get; set; }

    [Column("GSTIncluded")]
    public bool? Gstincluded { get; set; }

    public bool? Budgeted { get; set; }

    public bool? AutoApproved { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Request { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurchaseDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Reason { get; set; }

    public byte[]? Attachment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Timestamp { get; set; }
}
