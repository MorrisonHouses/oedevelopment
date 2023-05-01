using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class JcmMasterJobCustomField
{
    [StringLength(10)]
    [Unicode(false)]
    public string Job { get; set; } = null!;

    [Column("Lot_Purchase_Date", TypeName = "date")]
    public DateTime? LotPurchaseDate { get; set; }

    [Column("Actual_Lot_Cost")]
    public double? ActualLotCost { get; set; }

    [Column("Warranty_Expiry_Date", TypeName = "date")]
    public DateTime? WarrantyExpiryDate { get; set; }

    [Column("Framing_Start", TypeName = "date")]
    public DateTime? FramingStart { get; set; }

    [Column("Permit_Date", TypeName = "date")]
    public DateTime? PermitDate { get; set; }

    [Column("BAP_Job", TypeName = "numeric(10, 0)")]
    public decimal? BapJob { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Explanation { get; set; }
}
