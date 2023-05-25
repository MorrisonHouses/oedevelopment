using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

//[Table("tblCGYOE")]
public partial class TblCgyoe
{
    [Key]
    [Column("RequestID")]
    [DisplayName("ID")]
    public int RequestId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    [DisplayName("Ven ID")]
    public string? Vendor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    [DisplayName("Vendor")]
    public string? VendorName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    [DisplayName("Created By")]
    public string? RequestedBy { get; set; }

    [Column("GLAccount")]
    [StringLength(8)]
    [Unicode(false)]
    [DisplayName("GL")]
    public string? Glaccount { get; set; }

    public int? AutoApproveThreshold { get; set; }
    [DisplayName("Amount")]
    public double? Amount { get; set; }

    [Column("GSTAmount")]
    [DisplayName("GST")]
    public double? Gstamount { get; set; }
    [DisplayName("TTl Amt")]
    public double? TotalAmount { get; set; }

    [Column("GSTIncluded")]
    [DisplayName("GST Included")]
    public bool? Gstincluded { get; set; }

    public bool? Budgeted { get; set; }
    [DisplayName("Auto Approved")]
    public bool? AutoApproved { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Request { get; set; }

    [Column(TypeName = "datetime")]
    [DisplayName("Purchase Date")]
    public DateTime? PurchaseDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    [DisplayName("Approver")]
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
