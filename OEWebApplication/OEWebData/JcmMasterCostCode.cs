using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class JcmMasterCostCode
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

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Group_Cost_Code")]
    public bool GroupCostCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("Estimated_Start_Date", TypeName = "date")]
    public DateTime? EstimatedStartDate { get; set; }

    [Column("Estimated_Comp_Date", TypeName = "date")]
    public DateTime? EstimatedCompDate { get; set; }

    [Column("Revised_Start_Date", TypeName = "date")]
    public DateTime? RevisedStartDate { get; set; }

    [Column("Revised_Comp_Date", TypeName = "date")]
    public DateTime? RevisedCompDate { get; set; }

    [Column("Actual_Start_Date", TypeName = "date")]
    public DateTime? ActualStartDate { get; set; }

    [Column("Actual_Complete_Date", TypeName = "date")]
    public DateTime? ActualCompleteDate { get; set; }

    [Column("Last_Cost_Update", TypeName = "date")]
    public DateTime? LastCostUpdate { get; set; }

    [Column("Use_Empl_Work_StateLocal")]
    public bool UseEmplWorkStateLocal { get; set; }

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

    [Column("Billing_Item_Memo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? BillingItemMemo { get; set; }

    [Column("Bought_Out")]
    public bool BoughtOut { get; set; }

    [Column("Orig_Scheduled_Value")]
    public double? OrigScheduledValue { get; set; }

    [Column("Potential_CO_Schdld_Value_Chgs")]
    public double? PotentialCoSchdldValueChgs { get; set; }

    [Column("CO_Request_Schdld_Value_Chgs")]
    public double? CoRequestSchdldValueChgs { get; set; }

    [Column("Verbal_Okay_Schdld_Value_Chgs")]
    public double? VerbalOkaySchdldValueChgs { get; set; }

    [Column("JTD_Aprvd_Schd_Value_Chgs")]
    public double? JtdAprvdSchdValueChgs { get; set; }

    [Column("Revised_Scheduled_Value")]
    public double? RevisedScheduledValue { get; set; }

    [Column("YTD_Aprvd_Schd_Value_Chgs")]
    public double? YtdAprvdSchdValueChgs { get; set; }

    [Column("QTD_Aprvd_Schd_Value_Chgs")]
    public double? QtdAprvdSchdValueChgs { get; set; }

    [Column("MTD_Aprvd_Schd_Value_Chgs")]
    public double? MtdAprvdSchdValueChgs { get; set; }

    [Column("LM_Aprvd_Schd_Value_Chgs")]
    public double? LmAprvdSchdValueChgs { get; set; }

    [Column("NM_Aprvd_Schd_Value_Chgs")]
    public double? NmAprvdSchdValueChgs { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Contract { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Item { get; set; }

    [Column("Send_Cost_to_Billings")]
    public bool SendCostToBillings { get; set; }

    [Column("Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string ExemptStatus { get; set; } = null!;

    [Column("JTD_Work_Billed")]
    public double? JtdWorkBilled { get; set; }

    [Column("YTD_Work_Billed")]
    public double? YtdWorkBilled { get; set; }

    [Column("QTD_Work_Billed")]
    public double? QtdWorkBilled { get; set; }

    [Column("MTD_Work_Billed")]
    public double? MtdWorkBilled { get; set; }

    [Column("LM_Work_Billed")]
    public double? LmWorkBilled { get; set; }

    [Column("NM_Work_Billed")]
    public double? NmWorkBilled { get; set; }

    [Column("JTD_Retainage_Held")]
    public double? JtdRetainageHeld { get; set; }

    [Column("YTD_Retainage_Held")]
    public double? YtdRetainageHeld { get; set; }

    [Column("QTD_Retainage_Held")]
    public double? QtdRetainageHeld { get; set; }

    [Column("MTD_Retainage_Held")]
    public double? MtdRetainageHeld { get; set; }

    [Column("LM_Retainage_Held")]
    public double? LmRetainageHeld { get; set; }

    [Column("NM_Retainage_Held")]
    public double? NmRetainageHeld { get; set; }

    [Column("Original_Estimate")]
    public double? OriginalEstimate { get; set; }

    [Column("Pending_Estimate_Changes")]
    public double? PendingEstimateChanges { get; set; }

    [Column("JTD_Aprvd_Estimate_Chgs")]
    public double? JtdAprvdEstimateChgs { get; set; }

    [Column("Total_Estimate")]
    public double? TotalEstimate { get; set; }

    [Column("YTD_Aprvd_Estimate_Chgs")]
    public double? YtdAprvdEstimateChgs { get; set; }

    [Column("QTD_Aprvd_Estimate_Chgs")]
    public double? QtdAprvdEstimateChgs { get; set; }

    [Column("MTD_Aprvd_Estimate_Chgs")]
    public double? MtdAprvdEstimateChgs { get; set; }

    [Column("LM_Aprvd_Estimate_Chgs")]
    public double? LmAprvdEstimateChgs { get; set; }

    [Column("NM_Aprvd_Estimate_Chgs")]
    public double? NmAprvdEstimateChgs { get; set; }

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

    [Column("Total_Labor_Estimate")]
    public double? TotalLaborEstimate { get; set; }

    [Column("Total_Labor_Units_Est")]
    public double? TotalLaborUnitsEst { get; set; }

    [Column("Total_Material_Estimate")]
    public double? TotalMaterialEstimate { get; set; }

    [Column("Total_Subcontract_Est")]
    public double? TotalSubcontractEst { get; set; }

    [Column("Total_Equipment_Estimate")]
    public double? TotalEquipmentEstimate { get; set; }

    [Column("Total_Equipment_Units_Est")]
    public double? TotalEquipmentUnitsEst { get; set; }

    [Column("Total_Overhead_Est")]
    public double? TotalOverheadEst { get; set; }

    [Column("Total_Other_Estimate")]
    public double? TotalOtherEstimate { get; set; }

    [Column("Total_Labor_Commitment")]
    public double? TotalLaborCommitment { get; set; }

    [Column("Total_Material_Commitment")]
    public double? TotalMaterialCommitment { get; set; }

    [Column("Total_Sub_Commitment")]
    public double? TotalSubCommitment { get; set; }

    [Column("Total_Equipment_Commitment")]
    public double? TotalEquipmentCommitment { get; set; }

    [Column("Total_Overhead_Commitment")]
    public double? TotalOverheadCommitment { get; set; }

    [Column("Total_Other_Commitment")]
    public double? TotalOtherCommitment { get; set; }

    [Column("Commitment_Invoiced__Labor")]
    public double? CommitmentInvoicedLabor { get; set; }

    [Column("Commitment_Invoiced__Material")]
    public double? CommitmentInvoicedMaterial { get; set; }

    [Column("Commitment_Invoiced__Sub")]
    public double? CommitmentInvoicedSub { get; set; }

    [Column("Commitment_Invoiced__Equipment")]
    public double? CommitmentInvoicedEquipment { get; set; }

    [Column("Commitment_Invoiced__Overhead")]
    public double? CommitmentInvoicedOverhead { get; set; }

    [Column("Commitment_Invoiced__Other")]
    public double? CommitmentInvoicedOther { get; set; }

    [Column("JTD_Labor_Cost")]
    public double? JtdLaborCost { get; set; }

    [Column("JTD_Labor_Units")]
    public double? JtdLaborUnits { get; set; }

    [Column("JTD_Material_Cost")]
    public double? JtdMaterialCost { get; set; }

    [Column("JTD_Subcontract_Cost")]
    public double? JtdSubcontractCost { get; set; }

    [Column("JTD_Equipment_Cost")]
    public double? JtdEquipmentCost { get; set; }

    [Column("JTD_Equipment_Units")]
    public double? JtdEquipmentUnits { get; set; }

    [Column("JTD_Overhead_Cost")]
    public double? JtdOverheadCost { get; set; }

    [Column("JTD_Other_Cost")]
    public double? JtdOtherCost { get; set; }

    [Column("MTD_Labor_Cost")]
    public double? MtdLaborCost { get; set; }

    [Column("MTD_Labor_Units")]
    public double? MtdLaborUnits { get; set; }

    [Column("MTD_Material_Cost")]
    public double? MtdMaterialCost { get; set; }

    [Column("MTD_Subcontract_Cost")]
    public double? MtdSubcontractCost { get; set; }

    [Column("MTD_Equipment_Cost")]
    public double? MtdEquipmentCost { get; set; }

    [Column("MTD_Equipment_Units")]
    public double? MtdEquipmentUnits { get; set; }

    [Column("MTD_Overhead_Cost")]
    public double? MtdOverheadCost { get; set; }

    [Column("MTD_Other_Cost")]
    public double? MtdOtherCost { get; set; }

    [Column("LM_Labor_Cost")]
    public double? LmLaborCost { get; set; }

    [Column("LM_Labor_Units")]
    public double? LmLaborUnits { get; set; }

    [Column("LM_Material_Cost")]
    public double? LmMaterialCost { get; set; }

    [Column("LM_Subcontract_Cost")]
    public double? LmSubcontractCost { get; set; }

    [Column("LM_Equipment_Cost")]
    public double? LmEquipmentCost { get; set; }

    [Column("LM_Equipment_Units")]
    public double? LmEquipmentUnits { get; set; }

    [Column("LM_Overhead_Cost")]
    public double? LmOverheadCost { get; set; }

    [Column("LM_Other_Cost")]
    public double? LmOtherCost { get; set; }

    [Column("NM_Labor_Cost")]
    public double? NmLaborCost { get; set; }

    [Column("NM_Labor_Units")]
    public double? NmLaborUnits { get; set; }

    [Column("NM_Material_Cost")]
    public double? NmMaterialCost { get; set; }

    [Column("NM_Subcontract_Cost")]
    public double? NmSubcontractCost { get; set; }

    [Column("NM_Equipment_Cost")]
    public double? NmEquipmentCost { get; set; }

    [Column("NM_Equipment_Units")]
    public double? NmEquipmentUnits { get; set; }

    [Column("NM_Overhead_Cost")]
    public double? NmOverheadCost { get; set; }

    [Column("NM_Other_Cost")]
    public double? NmOtherCost { get; set; }

    [Column("WTD_Labor_Cost")]
    public double? WtdLaborCost { get; set; }

    [Column("WTD_Labor_Units")]
    public double? WtdLaborUnits { get; set; }

    [Column("WTD_Equipment_Cost")]
    public double? WtdEquipmentCost { get; set; }

    [Column("WTD_Equipment_Units")]
    public double? WtdEquipmentUnits { get; set; }

    [Column("JTD_Labor_Dollars_Paid")]
    public double? JtdLaborDollarsPaid { get; set; }

    [Column("JTD_Mat_Dollars_Paid")]
    public double? JtdMatDollarsPaid { get; set; }

    [Column("JTD_Sub_Dollars_Paid")]
    public double? JtdSubDollarsPaid { get; set; }

    [Column("JTD_Equipment_Dollars_Paid")]
    public double? JtdEquipmentDollarsPaid { get; set; }

    [Column("JTD_Overhead_Dollars_Paid")]
    public double? JtdOverheadDollarsPaid { get; set; }

    [Column("JTD_Other_Dollars_Paid")]
    public double? JtdOtherDollarsPaid { get; set; }

    [Column("Percent_Complete")]
    public double? PercentComplete { get; set; }

    [Column("Date_Pct_Complete_Entered", TypeName = "date")]
    public DateTime? DatePctCompleteEntered { get; set; }

    [Column("Previous_Percent_Complete")]
    public double? PreviousPercentComplete { get; set; }

    [Column("Production_Unit_Desc")]
    [StringLength(6)]
    [Unicode(false)]
    public string? ProductionUnitDesc { get; set; }

    [Column("Orig_Production_Units_Est")]
    public double? OrigProductionUnitsEst { get; set; }

    [Column("Pndng_Prodctn_Unit_Chgs")]
    public double? PndngProdctnUnitChgs { get; set; }

    [Column("Apprvd_Prodctn_Unit_Chgs")]
    public double? ApprvdProdctnUnitChgs { get; set; }

    [Column("Revised_Prodctn_Units_Est")]
    public double? RevisedProdctnUnitsEst { get; set; }

    [Column("JTD_Production_Units")]
    public double? JtdProductionUnits { get; set; }

    [Column("YTD_Production_Units")]
    public double? YtdProductionUnits { get; set; }

    [Column("QTD_Production_Units")]
    public double? QtdProductionUnits { get; set; }

    [Column("MTD_Production_Units")]
    public double? MtdProductionUnits { get; set; }

    [Column("LM_Production_Units")]
    public double? LmProductionUnits { get; set; }

    [Column("NM_Production_Units")]
    public double? NmProductionUnits { get; set; }

    [Column("WTD_Production_Units")]
    public double? WtdProductionUnits { get; set; }

    [Column("LW_Production_Units")]
    public double? LwProductionUnits { get; set; }

    [Column("Last_Reported_Prdctn_Unts")]
    public double? LastReportedPrdctnUnts { get; set; }

    [Column("Date_Last_Rptd_Prdctn_Uts", TypeName = "date")]
    public DateTime? DateLastRptdPrdctnUts { get; set; }

    [Column("Stored_Material")]
    public double? StoredMaterial { get; set; }

    [Column("Cost_At_Comp")]
    public double? CostAtComp { get; set; }

    [Column("Cost_To_Comp")]
    public double? CostToComp { get; set; }

    [Column("Lab_Hrs_To_Comp")]
    public double? LabHrsToComp { get; set; }

    [Column("Msc_CC_Amt_5")]
    public double? MscCcAmt5 { get; set; }

    [Column("Msc_CC_Amt_6")]
    public double? MscCcAmt6 { get; set; }

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

    [Column("Cost_Code_Notes", TypeName = "text")]
    public string? CostCodeNotes { get; set; }

    [Column("Cost_Code_File_Links", TypeName = "text")]
    public string? CostCodeFileLinks { get; set; }
}
