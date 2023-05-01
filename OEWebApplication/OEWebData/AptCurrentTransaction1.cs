using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class AptCurrentTransaction1
{
    [StringLength(10)]
    [Unicode(false)]
    public string Vendor { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Invoice { get; set; } = null!;

    [Column("Dist_Seq", TypeName = "numeric(5, 0)")]
    public decimal DistSeq { get; set; }

    [Column("Run_Number", TypeName = "numeric(10, 0)")]
    public decimal RunNumber { get; set; }

    [Column("Sequence_Number", TypeName = "numeric(10, 0)")]
    public decimal SequenceNumber { get; set; }

    public double? Amount { get; set; }

    public double? Retainage { get; set; }

    public double? Discount { get; set; }

    [Column("Misc_Deduction")]
    public double? MiscDeduction { get; set; }

    [Column("Misc_Deduction2_Deducted")]
    public double? MiscDeduction2Deducted { get; set; }

    [Column("Reference_Date", TypeName = "date")]
    public DateTime? ReferenceDate { get; set; }

    [Column("Accounting_Date", TypeName = "date")]
    public DateTime? AccountingDate { get; set; }

    [Column("Transaction_Date", TypeName = "date")]
    public DateTime? TransactionDate { get; set; }

    [Column("Transaction_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TransactionTaxGroup { get; set; }

    [Column("Payment_ID")]
    public double? PaymentId { get; set; }

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

    [Column("Expense_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? ExpenseAccount { get; set; }

    [Column("Accounts_Payable_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? AccountsPayableAccount { get; set; }

    [Column("Credit_Card_Payable_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CreditCardPayableAccount { get; set; }

    [Column("Retainage_Payable_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? RetainagePayableAccount { get; set; }

    [Column("Misc_Deduction_Credit_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? MiscDeductionCreditAccount { get; set; }

    [Column("Zero_Sumry_Entry_to_GL")]
    public bool? ZeroSumryEntryToGl { get; set; }

    [Column("Workflow_Program")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WorkflowProgram { get; set; }

    [Column("Transaction_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

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
