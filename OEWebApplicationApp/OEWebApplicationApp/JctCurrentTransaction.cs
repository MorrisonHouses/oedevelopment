using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class JctCurrentTransaction
{
    [StringLength(10)]
    [Unicode(false)]
    public string Job { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Extra { get; set; } = null!;

    [Column("Cost_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string CostCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Column("Transaction_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [Column(TypeName = "numeric(10, 0)")]
    public decimal Run { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal Sequence { get; set; }

    [Column("Transaction_Date", TypeName = "date")]
    public DateTime? TransactionDate { get; set; }

    [Column("Accounting_Date", TypeName = "date")]
    public DateTime? AccountingDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    public double? Units { get; set; }

    [Column("Unit_Cost")]
    public double? UnitCost { get; set; }

    public double? Amount { get; set; }

    [Column("Debit_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? DebitAccount { get; set; }

    [Column("Credit_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CreditAccount { get; set; }

    [Column("GL_Journal")]
    public byte? GlJournal { get; set; }

    [Column("Application_of_Origin")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ApplicationOfOrigin { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Batch { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Source { get; set; }

    [Column("Noncosted_Tax")]
    public double? NoncostedTax { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Invoice { get; set; }

    [Column("Dist_Sequence", TypeName = "numeric(5, 0)")]
    public decimal? DistSequence { get; set; }

    [Column("Commitment_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CommitmentType { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? Commitment { get; set; }

    [Column("Commitment_Line_Item", TypeName = "numeric(5, 0)")]
    public decimal? CommitmentLineItem { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Employee { get; set; }

    [Column("Period_End_Date", TypeName = "date")]
    public DateTime? PeriodEndDate { get; set; }

    [Column("Check_Sequence")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CheckSequence { get; set; }

    [Column("Pay_ID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PayId { get; set; }

    [Column("Tax_ID")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TaxId { get; set; }

    [Column("Fringe_ID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? FringeId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Equipment { get; set; }

    [Column("Equipment_Type")]
    [StringLength(5)]
    [Unicode(false)]
    public string? EquipmentType { get; set; }

    [Column("Ref_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ref1 { get; set; }

    [Column("Ref_2")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ref2 { get; set; }

    [Column("Change_Order")]
    [StringLength(5)]
    [Unicode(false)]
    public string? ChangeOrder { get; set; }

    [Column("Commitment_CO")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommitmentCo { get; set; }

    [Column("AP_Payment_ID")]
    public double? ApPaymentId { get; set; }

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

    [Column("Deposit_Id")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DepositId { get; set; }

    [Column("Deposit_Date", TypeName = "date")]
    public DateTime? DepositDate { get; set; }

    [Column("Deposit_Adjustment")]
    public bool DepositAdjustment { get; set; }

    public double? Retainage { get; set; }

    [Column("Debit_Account_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? DebitAccount2 { get; set; }

    [Column("Credit_Account_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CreditAccount2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Draw { get; set; }

    public bool Billed { get; set; }

    [Column("Customer_Check", TypeName = "numeric(10, 0)")]
    public decimal? CustomerCheck { get; set; }

    [Column("DP_Original_Location")]
    [StringLength(4)]
    [Unicode(false)]
    public string? DpOriginalLocation { get; set; }

    [Column("DP_Run_Number")]
    public double? DpRunNumber { get; set; }

    [Column("DP_Sequence", TypeName = "numeric(10, 0)")]
    public decimal? DpSequence { get; set; }

    [Column("Revenue_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? RevenueCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [Column("Amount_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AmountType { get; set; }

    [Column("Cash_Receipt_ID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CashReceiptId { get; set; }

    [Column("Adjustment_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AdjustmentType { get; set; }

    [Column("Adjustment_ID", TypeName = "numeric(10, 0)")]
    public decimal? AdjustmentId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Contract { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Item { get; set; }

    [Column("SM_Work_Order")]
    public double? SmWorkOrder { get; set; }

    [Column("Transaction_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionStatus { get; set; }

    [Column("Original_Source")]
    public byte? OriginalSource { get; set; }

    [Column("Standard_Item")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StandardItem { get; set; }

    [Column("WIP_ID", TypeName = "numeric(10, 0)")]
    public decimal? WipId { get; set; }

    [Column("Change_Request_Index")]
    public double? ChangeRequestIndex { get; set; }

    [Column("Change_Request_Detail_Index")]
    public double? ChangeRequestDetailIndex { get; set; }

    [Column("Addon_Index")]
    public double? AddonIndex { get; set; }

    [Column("Change_Order_Index")]
    public double? ChangeOrderIndex { get; set; }

    [Column("Commitment_CO_Index")]
    public double? CommitmentCoIndex { get; set; }

    [Column("CCOD_Index")]
    public double? CcodIndex { get; set; }

    [Column("Paid_Secondary_Vendor_Id")]
    public double? PaidSecondaryVendorId { get; set; }

    [Column("Chg_Mgmt_URL")]
    [StringLength(260)]
    [Unicode(false)]
    public string? ChgMgmtUrl { get; set; }

    [Column("Chg_Mgmt_Ref_1")]
    [StringLength(36)]
    [Unicode(false)]
    public string? ChgMgmtRef1 { get; set; }

    [Column("Chg_Mgmt_Ref_2")]
    [StringLength(36)]
    [Unicode(false)]
    public string? ChgMgmtRef2 { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }

    [Column("Transaction_File_Links", TypeName = "text")]
    public string? TransactionFileLinks { get; set; }
}
