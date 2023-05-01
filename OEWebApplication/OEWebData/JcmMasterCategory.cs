using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class JcmMasterCategory
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

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("Estimated_Start_Date", TypeName = "date")]
    public DateTime? EstimatedStartDate { get; set; }

    [Column("Estimated_Completion_Date", TypeName = "date")]
    public DateTime? EstimatedCompletionDate { get; set; }

    [Column("Revised_Start_Date", TypeName = "date")]
    public DateTime? RevisedStartDate { get; set; }

    [Column("Revised_Completion_Date", TypeName = "date")]
    public DateTime? RevisedCompletionDate { get; set; }

    [Column("Actual_Start_Date", TypeName = "date")]
    public DateTime? ActualStartDate { get; set; }

    [Column("Actual_Completion_Date", TypeName = "date")]
    public DateTime? ActualCompletionDate { get; set; }

    [Column("Last_Cost_Update", TypeName = "date")]
    public DateTime? LastCostUpdate { get; set; }

    [Column("Accumulate_As")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AccumulateAs { get; set; }

    [Column("Cost_Unit_Description")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CostUnitDescription { get; set; }

    [Column("Cost_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostAccount { get; set; }

    [Column("Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string ExemptStatus { get; set; } = null!;

    [Column("Bought_Out")]
    public bool BoughtOut { get; set; }

    [Column("Original_Estimate")]
    public double? OriginalEstimate { get; set; }

    [Column("Pending_Estimate_Changes")]
    public double? PendingEstimateChanges { get; set; }

    [Column("Approved_Estimate_Changes")]
    public double? ApprovedEstimateChanges { get; set; }

    [Column("Total_Estimate")]
    public double? TotalEstimate { get; set; }

    [Column("Original_Estimate_Units")]
    public double? OriginalEstimateUnits { get; set; }

    [Column("Pending_Est_Unit_Changes")]
    public double? PendingEstUnitChanges { get; set; }

    [Column("Approved_Est_Unit_Changes")]
    public double? ApprovedEstUnitChanges { get; set; }

    [Column("Total_Estimate_Units")]
    public double? TotalEstimateUnits { get; set; }

    [Column("Original_Commitment")]
    public double? OriginalCommitment { get; set; }

    [Column("Pending_Commitment_Changes")]
    public double? PendingCommitmentChanges { get; set; }

    [Column("Approved_Commitment_Changes")]
    public double? ApprovedCommitmentChanges { get; set; }

    [Column("Revised_Commitment")]
    public double? RevisedCommitment { get; set; }

    [Column("Commitment_Invoiced")]
    public double? CommitmentInvoiced { get; set; }

    [Column("JTD_Cost")]
    public double? JtdCost { get; set; }

    [Column("YTD_Cost")]
    public double? YtdCost { get; set; }

    [Column("QTD_Cost")]
    public double? QtdCost { get; set; }

    [Column("MTD_Cost")]
    public double? MtdCost { get; set; }

    [Column("LM_Cost")]
    public double? LmCost { get; set; }

    [Column("NM_Cost")]
    public double? NmCost { get; set; }

    [Column("WTD_Cost")]
    public double? WtdCost { get; set; }

    [Column("LW_Cost")]
    public double? LwCost { get; set; }

    [Column("Tax_on_JTD_Cost")]
    public double? TaxOnJtdCost { get; set; }

    [Column("Tax_on_YTD_Cost")]
    public double? TaxOnYtdCost { get; set; }

    [Column("Tax_on_QTD_Cost")]
    public double? TaxOnQtdCost { get; set; }

    [Column("Tax_on_MTD_Cost")]
    public double? TaxOnMtdCost { get; set; }

    [Column("Tax_on_LM_Cost")]
    public double? TaxOnLmCost { get; set; }

    [Column("Tax_on_NM_Cost")]
    public double? TaxOnNmCost { get; set; }

    [Column("Tax_on_WTD_Cost")]
    public double? TaxOnWtdCost { get; set; }

    [Column("Tax_on_LW_Cost")]
    public double? TaxOnLwCost { get; set; }

    [Column("JTD_Units")]
    public double? JtdUnits { get; set; }

    [Column("YTD_Units")]
    public double? YtdUnits { get; set; }

    [Column("QTD_Units")]
    public double? QtdUnits { get; set; }

    [Column("MTD_Units")]
    public double? MtdUnits { get; set; }

    [Column("LM_Units")]
    public double? LmUnits { get; set; }

    [Column("NM_Units")]
    public double? NmUnits { get; set; }

    [Column("WTD_Units")]
    public double? WtdUnits { get; set; }

    [Column("LW_Units")]
    public double? LwUnits { get; set; }

    [Column("JTD_Dollars_Paid")]
    public double? JtdDollarsPaid { get; set; }

    [Column("YTD_Dollars_Paid")]
    public double? YtdDollarsPaid { get; set; }

    [Column("QTD_Dollars_Paid")]
    public double? QtdDollarsPaid { get; set; }

    [Column("MTD_Dollars_Paid")]
    public double? MtdDollarsPaid { get; set; }

    [Column("LM_Dollars_Paid")]
    public double? LmDollarsPaid { get; set; }

    [Column("NM_Dollars_Paid")]
    public double? NmDollarsPaid { get; set; }

    [Column("WTD_Dollars_Paid")]
    public double? WtdDollarsPaid { get; set; }

    [Column("LW_Dollars_Paid")]
    public double? LwDollarsPaid { get; set; }

    [Column("Tax_on_JTD_Dollars_Paid")]
    public double? TaxOnJtdDollarsPaid { get; set; }

    [Column("Tax_on_YTD_Dollars_Paid")]
    public double? TaxOnYtdDollarsPaid { get; set; }

    [Column("Tax_on_QTD_Dollars_Paid")]
    public double? TaxOnQtdDollarsPaid { get; set; }

    [Column("Tax_on_MTD_Dollars_Paid")]
    public double? TaxOnMtdDollarsPaid { get; set; }

    [Column("Tax_on_LM_Dollars_Paid")]
    public double? TaxOnLmDollarsPaid { get; set; }

    [Column("Tax_on_NM_Dollars_Paid")]
    public double? TaxOnNmDollarsPaid { get; set; }

    [Column("Tax_on_WTD_Dollars_Pd")]
    public double? TaxOnWtdDollarsPd { get; set; }

    [Column("Tax_on_LW_Dollars_Paid")]
    public double? TaxOnLwDollarsPaid { get; set; }

    [Column("Percent_Complete")]
    public double? PercentComplete { get; set; }

    [Column("Date_Pct_Complete_Entered", TypeName = "date")]
    public DateTime? DatePctCompleteEntered { get; set; }

    [Column("Previous_Percent_Complete")]
    public double? PreviousPercentComplete { get; set; }

    [Column("Msc_Cat_Amt_1")]
    public double? MscCatAmt1 { get; set; }

    [Column("Msc_Cat_Amt_2")]
    public double? MscCatAmt2 { get; set; }

    [Column("Msc_Cat_Amt_3")]
    public double? MscCatAmt3 { get; set; }

    [Column("Msc_Cat_Amt_4")]
    public double? MscCatAmt4 { get; set; }

    [Column("Custom_Total_1_Total")]
    public double? CustomTotal1Total { get; set; }

    [Column("Custom_Total_2_Total")]
    public double? CustomTotal2Total { get; set; }

    [Column("Custom_Total_3_Total")]
    public double? CustomTotal3Total { get; set; }

    [Column("Custom_Total_4_Total")]
    public double? CustomTotal4Total { get; set; }

    [Column("Custom_Total_5_Total")]
    public double? CustomTotal5Total { get; set; }

    [Column("Custom_Total_6_Total")]
    public double? CustomTotal6Total { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }

    [Column("Row_ID")]
    [StringLength(36)]
    [Unicode(false)]
    public string? RowId { get; set; }

    [Column("Row_Version")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RowVersion { get; set; }
}
