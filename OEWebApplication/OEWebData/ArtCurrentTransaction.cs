using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class ArtCurrentTransaction
{
    [StringLength(10)]
    [Unicode(false)]
    public string Customer { get; set; } = null!;

    [Column("Transaction_Date", TypeName = "date")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal Run { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal Sequence { get; set; }

    [Column("Transaction_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

    [Column("Amount_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AmountType { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Invoice { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Draw { get; set; }

    [Column("Reference_Date", TypeName = "date")]
    public DateTime? ReferenceDate { get; set; }

    [Column("Due_Date", TypeName = "date")]
    public DateTime? DueDate { get; set; }

    [Column("Dep_Item_Type_Number", TypeName = "numeric(5, 0)")]
    public decimal? DepItemTypeNumber { get; set; }

    [Column("Dep_Item_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string DepItemType { get; set; } = null!;

    [Column("Cash_Receipt_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CashReceiptType { get; set; }

    [Column("Cash_Receipt")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CashReceipt { get; set; }

    [Column("Bank_Account")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [Column("Deposit_Date", TypeName = "date")]
    public DateTime? DepositDate { get; set; }

    [Column("Deposit_Id")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DepositId { get; set; }

    [Column("Deposit_Item", TypeName = "numeric(5, 0)")]
    public decimal? DepositItem { get; set; }

    [Column("Type_Adjusted")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TypeAdjusted { get; set; }

    [Column("Adjustment_TypeNumber", TypeName = "numeric(5, 0)")]
    public decimal? AdjustmentTypeNumber { get; set; }

    [Column("Adjustment_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentType { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Adjustment { get; set; }

    [Column("Edit_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EditType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Contract { get; set; }

    [Column("Contract_Item")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ContractItem { get; set; }

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

    [Column("Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TaxGroup { get; set; }

    [Column("Tax_ID")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TaxId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ExemptStatus { get; set; }

    [Column("Tax_Rate")]
    public double? TaxRate { get; set; }

    public double? Taxable { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Debit_Account__Accrual")]
    [StringLength(25)]
    [Unicode(false)]
    public string? DebitAccountAccrual { get; set; }

    [Column("Credit_Account__Accrual")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CreditAccountAccrual { get; set; }

    [Column("Retainage_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? RetainageAccount { get; set; }

    [Column("Tax_Retainage_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? TaxRetainageAccount { get; set; }

    [Column("Debit_Account__Cash")]
    [StringLength(25)]
    [Unicode(false)]
    public string? DebitAccountCash { get; set; }

    [Column("Credit_Account__Cash")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CreditAccountCash { get; set; }

    [Column("Intercompany_Payable")]
    [StringLength(25)]
    [Unicode(false)]
    public string? IntercompanyPayable { get; set; }

    [Column("Intercompany_Receivable")]
    [StringLength(25)]
    [Unicode(false)]
    public string? IntercompanyReceivable { get; set; }

    [Column("Accounting_Date", TypeName = "date")]
    public DateTime? AccountingDate { get; set; }

    [Column("GL_Journal")]
    public byte? GlJournal { get; set; }

    public double? Units { get; set; }

    public double? Amount { get; set; }

    public double? Retainage { get; set; }

    [Column("Entry_Line", TypeName = "numeric(10, 0)")]
    public decimal? EntryLine { get; set; }

    [Column("Status_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? StatusType { get; set; }

    [Column("Status_Date", TypeName = "date")]
    public DateTime? StatusDate { get; set; }

    [Column("Status_Seq", TypeName = "numeric(5, 0)")]
    public decimal? StatusSeq { get; set; }

    [Column("Actvty_Seq", TypeName = "numeric(5, 0)")]
    public decimal? ActvtySeq { get; set; }

    [Column("Dist_Seq", TypeName = "numeric(5, 0)")]
    public decimal? DistSeq { get; set; }

    [Column("Related_Status_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RelatedStatusType { get; set; }

    [Column("Related_Status_Date", TypeName = "date")]
    public DateTime? RelatedStatusDate { get; set; }

    [Column("Related_Status_Seq", TypeName = "numeric(5, 0)")]
    public decimal? RelatedStatusSeq { get; set; }

    [Column("Related_Actvty_Seq", TypeName = "numeric(5, 0)")]
    public decimal? RelatedActvtySeq { get; set; }

    [Column("Related_Dist_Seq", TypeName = "numeric(5, 0)")]
    public decimal? RelatedDistSeq { get; set; }

    [Column("Generation_Date", TypeName = "date")]
    public DateTime? GenerationDate { get; set; }

    [Column("Generation_Seq", TypeName = "numeric(5, 0)")]
    public decimal? GenerationSeq { get; set; }

    [Column("Application_of_Origin")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ApplicationOfOrigin { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Batch { get; set; }

    [Column("Batch_Source")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BatchSource { get; set; }

    [Column("DP_Original_Location")]
    [StringLength(4)]
    [Unicode(false)]
    public string? DpOriginalLocation { get; set; }

    [Column("DP_Run_Number")]
    public double? DpRunNumber { get; set; }

    [Column("DP_Sequence", TypeName = "numeric(10, 0)")]
    public decimal? DpSequence { get; set; }

    [Column("SM_Work_Order")]
    public double? SmWorkOrder { get; set; }

    [Column("SM_Work_Order_Item")]
    public double? SmWorkOrderItem { get; set; }

    [Column("Location_Name")]
    [StringLength(40)]
    [Unicode(false)]
    public string? LocationName { get; set; }

    [Column("Change_Customer")]
    public bool ChangeCustomer { get; set; }

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
