using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class ApmMasterInvoicePayment
{
    [StringLength(10)]
    [Unicode(false)]
    public string Vendor { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Invoice { get; set; } = null!;

    [Column("Payment_ID")]
    public double PaymentId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Payment_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PaymentType { get; set; }

    [Column("Bank_Account")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? Check { get; set; }

    [Column("Amount_Paid")]
    public double? AmountPaid { get; set; }

    [Column("Tax_Paid")]
    public double? TaxPaid { get; set; }

    [Column("Discount_Taken")]
    public double? DiscountTaken { get; set; }

    [Column("Discount_Lost")]
    public double? DiscountLost { get; set; }

    [Column("Retainage_Held")]
    public double? RetainageHeld { get; set; }

    [Column("Retainage_Paid")]
    public double? RetainagePaid { get; set; }

    [Column("Misc_Deduction_Applied")]
    public double? MiscDeductionApplied { get; set; }

    [Column("Misc_Deduction2_Deducted")]
    public double? MiscDeduction2Deducted { get; set; }

    [Column("Paid_From_Open_Inv")]
    public bool PaidFromOpenInv { get; set; }

    public byte? Journal { get; set; }

    [Column("Payment_Memo")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PaymentMemo { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }
}
