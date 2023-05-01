using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class ApmMasterDistribution
{
    [StringLength(10)]
    [Unicode(false)]
    public string Vendor { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Invoice { get; set; } = null!;

    [Column("Dist_Seq", TypeName = "numeric(5, 0)")]
    public decimal DistSeq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    public double? Amount { get; set; }

    [Column("Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TaxGroup { get; set; }

    public double? Tax { get; set; }

    [Column("Tax_Liability")]
    public double? TaxLiability { get; set; }

    [Column("Discount_Offered")]
    public double? DiscountOffered { get; set; }

    public double? Retainage { get; set; }

    [Column("Misc_Deduction")]
    public double? MiscDeduction { get; set; }

    [Column("Misc_Deduction2_Percent")]
    public double? MiscDeduction2Percent { get; set; }

    [Column("Amount_Paid")]
    public double? AmountPaid { get; set; }

    [Column("Tax_Paid")]
    public double? TaxPaid { get; set; }

    [Column("Tax_Liability_Accounted")]
    public double? TaxLiabilityAccounted { get; set; }

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

    [Column("Exempt_1099")]
    public bool Exempt1099 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Authorization { get; set; }

    public bool Completed { get; set; }

    public bool Approved { get; set; }

    [Column("Dist_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DistCode { get; set; }

    [Column("Expense_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? ExpenseAccount { get; set; }

    [Column("Accounts_Payable_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? AccountsPayableAccount { get; set; }

    [Column("Retainage_Payable_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? RetainagePayableAccount { get; set; }

    [Column("Misc_Deduction_Credit_Acct")]
    [StringLength(25)]
    [Unicode(false)]
    public string? MiscDeductionCreditAcct { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Job { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Extra { get; set; }

    [Column("Cost_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? CostCode { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? Commitment { get; set; }

    [Column("Commitment_Line_Item", TypeName = "numeric(10, 0)")]
    public decimal? CommitmentLineItem { get; set; }

    public double? Units { get; set; }

    [Column("Unit_Cost")]
    public double? UnitCost { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Draw { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Equipment { get; set; }

    [Column("Misc_Entry_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MiscEntry1 { get; set; }

    [Column("Misc_Entry_Units_1")]
    public double? MiscEntryUnits1 { get; set; }

    [Column("Misc_Entry_2")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MiscEntry2 { get; set; }

    [Column("Misc_Entry_Units_2")]
    public double? MiscEntryUnits2 { get; set; }

    public double? MeterOdometer { get; set; }

    [Column("Standard_Item")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StandardItem { get; set; }

    [Column("PM_Chargeback")]
    public bool PmChargeback { get; set; }

    [Column("PM_Property")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmProperty { get; set; }

    [Column("PM_Unit")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmUnit { get; set; }

    [Column("PM_Lease")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PmLease { get; set; }

    [Column("PM_Lease_Revision_Num", TypeName = "numeric(5, 0)")]
    public decimal? PmLeaseRevisionNum { get; set; }

    [Column("PM_Tenant")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmTenant { get; set; }

    [Column("PM_Charge_Type")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmChargeType { get; set; }

    [Column("PM_Charge_Date", TypeName = "date")]
    public DateTime? PmChargeDate { get; set; }

    [Column("PM_Item_ID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PmItemId { get; set; }

    [Column("PM_Chargeback_Description")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PmChargebackDescription { get; set; }

    [Column("PM_Markup_Percent")]
    public double? PmMarkupPercent { get; set; }

    [Column("PM_Markup_Amount")]
    public double? PmMarkupAmount { get; set; }

    [Column("PM_Markup_Charge_Type")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmMarkupChargeType { get; set; }

    [Column("Bank_Account")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [Column("Joint_Payee")]
    [StringLength(30)]
    [Unicode(false)]
    public string? JointPayee { get; set; }

    [Column("Allocation_Name")]
    [StringLength(12)]
    [Unicode(false)]
    public string? AllocationName { get; set; }

    [Column("Onhold_Status")]
    public byte? OnholdStatus { get; set; }

    [Column("Final_Lien_Waiver")]
    public bool FinalLienWaiver { get; set; }

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

    [Column("Upgrade_Flags")]
    public double? UpgradeFlags { get; set; }

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
