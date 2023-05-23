using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

//[Keyless]
public partial class ApmMasterInvoice
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Vendor { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Invoice { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    public double? Amount { get; set; }

    public double? Tax { get; set; }

    [Column("Discount_Offered")]
    public double? DiscountOffered { get; set; }

    public double? Retainage { get; set; }

    [Column("Misc_Deduction")]
    public double? MiscDeduction { get; set; }

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

    [Column("Invoice_Date", TypeName = "date")]
    public DateTime? InvoiceDate { get; set; }

    [Column("Date_Received", TypeName = "date")]
    public DateTime? DateReceived { get; set; }

    [Column("Discount_Date", TypeName = "date")]
    public DateTime? DiscountDate { get; set; }

    [Column("Payment_Date", TypeName = "date")]
    public DateTime? PaymentDate { get; set; }

    [Column("Accounting_Date", TypeName = "date")]
    public DateTime? AccountingDate { get; set; }

    [Column("Created_by")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column("Appl_of_Origin")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ApplOfOrigin { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Batch { get; set; }

    [Column("Batch_Source")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BatchSource { get; set; }

    [Column("DP_Location")]
    [StringLength(4)]
    [Unicode(false)]
    public string? DpLocation { get; set; }

    [Column("DP_Map_ID")]
    [StringLength(8)]
    [Unicode(false)]
    public string? DpMapId { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? Run { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? Sequence { get; set; }

    [Column("Pending_Invoice")]
    public bool PendingInvoice { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Session { get; set; }

    [Column("Due_Back_Date", TypeName = "date")]
    public DateTime? DueBackDate { get; set; }

    [Column("Invoice_Code_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceCode1 { get; set; }

    [Column("Invoice_Code_2")]
    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceCode2 { get; set; }

    public byte? Journal { get; set; }

    [Column("Smry_Payee_Name")]
    [StringLength(30)]
    [Unicode(false)]
    public string? SmryPayeeName { get; set; }

    [Column("Smry_Payee_Address_1")]
    [StringLength(33)]
    [Unicode(false)]
    public string? SmryPayeeAddress1 { get; set; }

    [Column("Smry_Payee_Address_2")]
    [StringLength(33)]
    [Unicode(false)]
    public string? SmryPayeeAddress2 { get; set; }

    [Column("Smry_Payee_City")]
    [StringLength(30)]
    [Unicode(false)]
    public string? SmryPayeeCity { get; set; }

    [Column("Smry_Payee_State")]
    [StringLength(4)]
    [Unicode(false)]
    public string? SmryPayeeState { get; set; }

    [Column("Smry_Payee_ZIP")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SmryPayeeZip { get; set; }

    [Column("Onhold_Status")]
    public byte? OnholdStatus { get; set; }

    [Column("Included_for_Pmt")]
    public bool IncludedForPmt { get; set; }

    [Column("Pmt_Amount")]
    public double? PmtAmount { get; set; }

    [Column("Pmt_Retainage_to_Pay")]
    public double? PmtRetainageToPay { get; set; }

    [Column("Pmt_Disc_to_Apply")]
    public double? PmtDiscToApply { get; set; }

    [Column("Pmt_Retainage_to_Hold")]
    public double? PmtRetainageToHold { get; set; }

    [Column("Pmt_Misc_Deduction_to_Deduct")]
    public double? PmtMiscDeductionToDeduct { get; set; }

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

    [Column("Invoice_Notes", TypeName = "text")]
    public string? InvoiceNotes { get; set; }

    [Column("Invoice_File_Links", TypeName = "text")]
    public string? InvoiceFileLinks { get; set; }
}
