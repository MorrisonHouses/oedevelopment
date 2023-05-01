using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class JcmMasterJob2
{
    [StringLength(10)]
    [Unicode(false)]
    public string Job { get; set; } = null!;

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

    [Column("JTD_Material_Dollars_Paid")]
    public double? JtdMaterialDollarsPaid { get; set; }

    [Column("JTD_Sub_Dollars_Paid")]
    public double? JtdSubDollarsPaid { get; set; }

    [Column("JTD_Equipment_Dollars_Paid")]
    public double? JtdEquipmentDollarsPaid { get; set; }

    [Column("JTD_Overhead_Dollars_Paid")]
    public double? JtdOverheadDollarsPaid { get; set; }

    [Column("JTD_Other_Dollars_Paid")]
    public double? JtdOtherDollarsPaid { get; set; }

    [Column("Date_of_Last_Report", TypeName = "date")]
    public DateTime? DateOfLastReport { get; set; }

    [Column("Percent_Complete")]
    public double? PercentComplete { get; set; }

    [Column("Msc_Job_Amt_1")]
    public double? MscJobAmt1 { get; set; }

    [Column("Msc_Job_Amt_2")]
    public double? MscJobAmt2 { get; set; }

    [Column("Msc_Job_Amt_3")]
    public double? MscJobAmt3 { get; set; }

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

    [Column("Last_Custom_Total_Update", TypeName = "date")]
    public DateTime? LastCustomTotalUpdate { get; set; }

    [Column("Extras_Orig_Contract_Amount")]
    public double? ExtrasOrigContractAmount { get; set; }

    [Column("Extras_Potential_CO_Contract_Changes")]
    public double? ExtrasPotentialCoContractChanges { get; set; }

    [Column("Extras_CO_Request_Contract_Changes")]
    public double? ExtrasCoRequestContractChanges { get; set; }

    [Column("Extras_Verbal_Okay_Contract_Changes")]
    public double? ExtrasVerbalOkayContractChanges { get; set; }

    [Column("Extras_JTD_Aprvd_Cntrc_Chgs")]
    public double? ExtrasJtdAprvdCntrcChgs { get; set; }

    [Column("Extras_Revised_Contract_Amt")]
    public double? ExtrasRevisedContractAmt { get; set; }

    [Column("Extras_YTD_Aprvd_Cntrc_Chgs")]
    public double? ExtrasYtdAprvdCntrcChgs { get; set; }

    [Column("Extras_QTD_Aprvd_Cntrc_Chgs")]
    public double? ExtrasQtdAprvdCntrcChgs { get; set; }

    [Column("Extras_MTD_Aprvd_Cntrc_Chgs")]
    public double? ExtrasMtdAprvdCntrcChgs { get; set; }

    [Column("Extras_LM_Aprvd_Cntrc_Chgs")]
    public double? ExtrasLmAprvdCntrcChgs { get; set; }

    [Column("Extras_NM_Aprvd_Cntrc_Chgs")]
    public double? ExtrasNmAprvdCntrcChgs { get; set; }

    [Column("Extras_JTD_Work_Billed")]
    public double? ExtrasJtdWorkBilled { get; set; }

    [Column("Extras_YTD_Work_Billed")]
    public double? ExtrasYtdWorkBilled { get; set; }

    [Column("Extras_QTD_Work_Billed")]
    public double? ExtrasQtdWorkBilled { get; set; }

    [Column("Extras_MTD_Work_Billed")]
    public double? ExtrasMtdWorkBilled { get; set; }

    [Column("Extras_LM_Work_Billed")]
    public double? ExtrasLmWorkBilled { get; set; }

    [Column("Extras_NM_Work_Billed")]
    public double? ExtrasNmWorkBilled { get; set; }

    [Column("Extras_JTD_Retainage_Held")]
    public double? ExtrasJtdRetainageHeld { get; set; }

    [Column("Extras_YTD_Retainage_Held")]
    public double? ExtrasYtdRetainageHeld { get; set; }

    [Column("Extras_QTD_Retainage_Held")]
    public double? ExtrasQtdRetainageHeld { get; set; }

    [Column("Extras_MTD_Retainage_Held")]
    public double? ExtrasMtdRetainageHeld { get; set; }

    [Column("Extras_LM_Retainage_Held")]
    public double? ExtrasLmRetainageHeld { get; set; }

    [Column("Extras_NM_Retainage_Held")]
    public double? ExtrasNmRetainageHeld { get; set; }

    [Column("Extras_JTD_Payments")]
    public double? ExtrasJtdPayments { get; set; }

    [Column("Extras_YTD_Payments")]
    public double? ExtrasYtdPayments { get; set; }

    [Column("Extras_QTD_Payments")]
    public double? ExtrasQtdPayments { get; set; }

    [Column("Extras_MTD_Payments")]
    public double? ExtrasMtdPayments { get; set; }

    [Column("Extras_LM_Payments")]
    public double? ExtrasLmPayments { get; set; }

    [Column("Extras_NM_Payments")]
    public double? ExtrasNmPayments { get; set; }

    [Column("Extras_JTD_Adjustment")]
    public double? ExtrasJtdAdjustment { get; set; }

    [Column("Extras_YTD_Adjustment")]
    public double? ExtrasYtdAdjustment { get; set; }

    [Column("Extras_QTD_Adjustment")]
    public double? ExtrasQtdAdjustment { get; set; }

    [Column("Extras_MTD_Adjustment")]
    public double? ExtrasMtdAdjustment { get; set; }

    [Column("Extras_LM_Adjustment")]
    public double? ExtrasLmAdjustment { get; set; }

    [Column("Extras_NM_Adjustment")]
    public double? ExtrasNmAdjustment { get; set; }

    [Column("Extras_Billing_Balance")]
    public double? ExtrasBillingBalance { get; set; }

    [Column("Extras_Original_Estimate")]
    public double? ExtrasOriginalEstimate { get; set; }

    [Column("Extras_Pndng_Estimate_Chgs")]
    public double? ExtrasPndngEstimateChgs { get; set; }

    [Column("Extras_JTD_Aprvd_Est_Chgs")]
    public double? ExtrasJtdAprvdEstChgs { get; set; }

    [Column("Extras_Total_Estimate")]
    public double? ExtrasTotalEstimate { get; set; }

    [Column("Extras_YTD_Aprvd_Est_Chgs")]
    public double? ExtrasYtdAprvdEstChgs { get; set; }

    [Column("Extras_QTD_Aprvd_Est_Chgs")]
    public double? ExtrasQtdAprvdEstChgs { get; set; }

    [Column("Extras_MTD_Aprvd_Est_Chgs")]
    public double? ExtrasMtdAprvdEstChgs { get; set; }

    [Column("Extras_LM_Aprvd_Est_Chgs")]
    public double? ExtrasLmAprvdEstChgs { get; set; }

    [Column("Extras_NM_Aprvd_Est_Chgs")]
    public double? ExtrasNmAprvdEstChgs { get; set; }

    [Column("Extra_Original_Commitment")]
    public double? ExtraOriginalCommitment { get; set; }

    [Column("Extra_Pending_Commitment_Changes")]
    public double? ExtraPendingCommitmentChanges { get; set; }

    [Column("Extra_Approved_Commitment_Changes")]
    public double? ExtraApprovedCommitmentChanges { get; set; }

    [Column("Extra_Revised_Commitment")]
    public double? ExtraRevisedCommitment { get; set; }

    [Column("Extra_Commitment_Invoiced")]
    public double? ExtraCommitmentInvoiced { get; set; }

    [Column("Extras_JTD_Cost")]
    public double? ExtrasJtdCost { get; set; }

    [Column("Extras_YTD_Cost")]
    public double? ExtrasYtdCost { get; set; }

    [Column("Extras_QTD_Cost")]
    public double? ExtrasQtdCost { get; set; }

    [Column("Extras_MTD_Cst")]
    public double? ExtrasMtdCst { get; set; }

    [Column("Extras_LM_Cost")]
    public double? ExtrasLmCost { get; set; }

    [Column("Extras_NM_Cost")]
    public double? ExtrasNmCost { get; set; }

    [Column("Extras_WTD_Cost")]
    public double? ExtrasWtdCost { get; set; }

    [Column("Extras_LW_Cost")]
    public double? ExtrasLwCost { get; set; }

    [Column("Tax_on_Extras_JTD_Cost")]
    public double? TaxOnExtrasJtdCost { get; set; }

    [Column("Tax_on_Extras_YTD_Cost")]
    public double? TaxOnExtrasYtdCost { get; set; }

    [Column("Tax_on_Extras_QTD_Cost")]
    public double? TaxOnExtrasQtdCost { get; set; }

    [Column("Tax_on_Extras_MTD_Cst")]
    public double? TaxOnExtrasMtdCst { get; set; }

    [Column("Tax_on_Extras_LM_Cost")]
    public double? TaxOnExtrasLmCost { get; set; }

    [Column("Tax_on_Extras_NM_Cost")]
    public double? TaxOnExtrasNmCost { get; set; }

    [Column("Tax_on_Extras_WTD_Cost")]
    public double? TaxOnExtrasWtdCost { get; set; }

    [Column("Tax_on_Extras_LW_Cost")]
    public double? TaxOnExtrasLwCost { get; set; }

    [Column("Extras_JTD_Dollars_Paid")]
    public double? ExtrasJtdDollarsPaid { get; set; }

    [Column("Extras_YTD_Dollars_Paid")]
    public double? ExtrasYtdDollarsPaid { get; set; }

    [Column("Extras_QTD_Dollars_Paid")]
    public double? ExtrasQtdDollarsPaid { get; set; }

    [Column("Extras_MTD_Dollars_Paid")]
    public double? ExtrasMtdDollarsPaid { get; set; }

    [Column("Extras_LM_Dollars_Paid")]
    public double? ExtrasLmDollarsPaid { get; set; }

    [Column("Extras_NM_Dollars_Paid")]
    public double? ExtrasNmDollarsPaid { get; set; }

    [Column("Extras_WTD_Dollars_Paid")]
    public double? ExtrasWtdDollarsPaid { get; set; }

    [Column("Extras_LW_Dollars_Paid")]
    public double? ExtrasLwDollarsPaid { get; set; }

    [Column("Tax_on_Extras_JTD_Dollrs_Pd")]
    public double? TaxOnExtrasJtdDollrsPd { get; set; }

    [Column("Tax_on_Extras_YTD_Dollrs_Pd")]
    public double? TaxOnExtrasYtdDollrsPd { get; set; }

    [Column("Tax_on_Extras_QTD_Dollrs_Pd")]
    public double? TaxOnExtrasQtdDollrsPd { get; set; }

    [Column("Tax_on_Extras_MTD_Dollrs_Pd")]
    public double? TaxOnExtrasMtdDollrsPd { get; set; }

    [Column("Tax_on_Extras_LM_Dollrs_Pd")]
    public double? TaxOnExtrasLmDollrsPd { get; set; }

    [Column("Tax_on_Extras_NM_Dollrs_Pd")]
    public double? TaxOnExtrasNmDollrsPd { get; set; }

    [Column("Tax_on_Extras_WTD_DP")]
    public double? TaxOnExtrasWtdDp { get; set; }

    [Column("Tax_on_Extras_LW_DP")]
    public double? TaxOnExtrasLwDp { get; set; }

    [Column("Extras_Total_Tax_Amount")]
    public double? ExtrasTotalTaxAmount { get; set; }

    [Column("Extras_Total_Labor_Estimate")]
    public double? ExtrasTotalLaborEstimate { get; set; }

    [Column("Extras_Total_Labor_Unts_Est")]
    public double? ExtrasTotalLaborUntsEst { get; set; }

    [Column("Extras_Total_Material_Est")]
    public double? ExtrasTotalMaterialEst { get; set; }

    [Column("Extra_Total_Sub_Estimate")]
    public double? ExtraTotalSubEstimate { get; set; }

    [Column("Extra_Total_Equipment_Estimate")]
    public double? ExtraTotalEquipmentEstimate { get; set; }

    [Column("Extra_Total_Equipment_Units_Est")]
    public double? ExtraTotalEquipmentUnitsEst { get; set; }

    [Column("Extra_Total_Overhead_Est")]
    public double? ExtraTotalOverheadEst { get; set; }

    [Column("Extra_Total_Other_Estimate")]
    public double? ExtraTotalOtherEstimate { get; set; }

    [Column("Extra_Total_Labor_Commitment")]
    public double? ExtraTotalLaborCommitment { get; set; }

    [Column("Extra_Total_Mat_Commitment")]
    public double? ExtraTotalMatCommitment { get; set; }

    [Column("Extra_Total_Sub_Commitment")]
    public double? ExtraTotalSubCommitment { get; set; }

    [Column("Extra_Total_Equipment_Commitment")]
    public double? ExtraTotalEquipmentCommitment { get; set; }

    [Column("Extra_Total_Overhead_Commitment")]
    public double? ExtraTotalOverheadCommitment { get; set; }

    [Column("Extra_Total_Other_Commitment")]
    public double? ExtraTotalOtherCommitment { get; set; }

    [Column("Extra_Commitment_Inv__Labor")]
    public double? ExtraCommitmentInvLabor { get; set; }

    [Column("Extra_Commitment_Inv__Material")]
    public double? ExtraCommitmentInvMaterial { get; set; }

    [Column("Extra_Commitment_Inv__Sub")]
    public double? ExtraCommitmentInvSub { get; set; }

    [Column("Extra_Commitment_Inv__Equipment")]
    public double? ExtraCommitmentInvEquipment { get; set; }

    [Column("Extra_Commitment_Inv__Overhead")]
    public double? ExtraCommitmentInvOverhead { get; set; }

    [Column("Extra_Commitment_Inv__Other")]
    public double? ExtraCommitmentInvOther { get; set; }

    [Column("Extras_JTD_Labor_Cost")]
    public double? ExtrasJtdLaborCost { get; set; }

    [Column("Extras_JTD_Labor_Units")]
    public double? ExtrasJtdLaborUnits { get; set; }

    [Column("Extras_JTD_Material_Cost")]
    public double? ExtrasJtdMaterialCost { get; set; }

    [Column("Extras_JTD_Sub_Cost")]
    public double? ExtrasJtdSubCost { get; set; }

    [Column("Extras_JTD_Equipment_Cost")]
    public double? ExtrasJtdEquipmentCost { get; set; }

    [Column("Extras_JTD_Equipment_Units")]
    public double? ExtrasJtdEquipmentUnits { get; set; }

    [Column("Extras_JTD_Overhead_Cost")]
    public double? ExtrasJtdOverheadCost { get; set; }

    [Column("Extras_JTD_Other_Cost")]
    public double? ExtrasJtdOtherCost { get; set; }

    [Column("Extras_MTD_Labor_Cost")]
    public double? ExtrasMtdLaborCost { get; set; }

    [Column("Extras_MTD_Labor_Units")]
    public double? ExtrasMtdLaborUnits { get; set; }

    [Column("Extras_MTD_Material_Cost")]
    public double? ExtrasMtdMaterialCost { get; set; }

    [Column("Extras_MTD_Sub_Cost")]
    public double? ExtrasMtdSubCost { get; set; }

    [Column("Extras_MTD_Equipment_Cost")]
    public double? ExtrasMtdEquipmentCost { get; set; }

    [Column("Extras_MTD_Equipment_Units")]
    public double? ExtrasMtdEquipmentUnits { get; set; }

    [Column("Extras_MTD_Overhead_Cost")]
    public double? ExtrasMtdOverheadCost { get; set; }

    [Column("Extras_MTD_Other_Cost")]
    public double? ExtrasMtdOtherCost { get; set; }

    [Column("Extras_LM_Labor_Cost")]
    public double? ExtrasLmLaborCost { get; set; }

    [Column("Extras_LM_Labor_Units")]
    public double? ExtrasLmLaborUnits { get; set; }

    [Column("Extras_LM_Material_Cost")]
    public double? ExtrasLmMaterialCost { get; set; }

    [Column("Extras_LM_Sub_Cost")]
    public double? ExtrasLmSubCost { get; set; }

    [Column("Extras_LM_Equipment_Cost")]
    public double? ExtrasLmEquipmentCost { get; set; }

    [Column("Extras_LM_Equipment_Units")]
    public double? ExtrasLmEquipmentUnits { get; set; }

    [Column("Extras_LM_Overhead_Cost")]
    public double? ExtrasLmOverheadCost { get; set; }

    [Column("Extras_LM_Other_Cost")]
    public double? ExtrasLmOtherCost { get; set; }

    [Column("Extras_NM_Labor_Cost")]
    public double? ExtrasNmLaborCost { get; set; }

    [Column("Extras_NM_Labor_Units")]
    public double? ExtrasNmLaborUnits { get; set; }

    [Column("Extras_NM_Material_Cost")]
    public double? ExtrasNmMaterialCost { get; set; }

    [Column("Extras_NM_Sub_Cost")]
    public double? ExtrasNmSubCost { get; set; }

    [Column("Extras_NM_Equipment_Cost")]
    public double? ExtrasNmEquipmentCost { get; set; }

    [Column("Extras_NM_Equipment_Units")]
    public double? ExtrasNmEquipmentUnits { get; set; }

    [Column("Extras_NM_Overhead_Cost")]
    public double? ExtrasNmOverheadCost { get; set; }

    [Column("Extras_NM_Other_Cost")]
    public double? ExtrasNmOtherCost { get; set; }

    [Column("Extras_WTD_Labor_Cost")]
    public double? ExtrasWtdLaborCost { get; set; }

    [Column("Extras_WTD_Labor_Units")]
    public double? ExtrasWtdLaborUnits { get; set; }

    [Column("Extras_WTD_Equipment_Cost")]
    public double? ExtrasWtdEquipmentCost { get; set; }

    [Column("Extras_WTD_Equipment_Units")]
    public double? ExtrasWtdEquipmentUnits { get; set; }

    [Column("Extras_JTD_Labor_Dllrs_Paid")]
    public double? ExtrasJtdLaborDllrsPaid { get; set; }

    [Column("Extras_JTD_Mat_Dllrs_Paid")]
    public double? ExtrasJtdMatDllrsPaid { get; set; }

    [Column("Extras_JTD_Sub_Dllrs_Paid")]
    public double? ExtrasJtdSubDllrsPaid { get; set; }

    [Column("Extras_JTD_Equipment_Dllrs_Paid")]
    public double? ExtrasJtdEquipmentDllrsPaid { get; set; }

    [Column("Extras_JTD_Ovrhd_Dllrs_Paid")]
    public double? ExtrasJtdOvrhdDllrsPaid { get; set; }

    [Column("Extras_JTD_Other_Dllrs_Paid")]
    public double? ExtrasJtdOtherDllrsPaid { get; set; }

    [Column("Msc_Extra_Amt_1")]
    public double? MscExtraAmt1 { get; set; }

    [Column("Msc_Extra_Amt_2")]
    public double? MscExtraAmt2 { get; set; }

    [Column("Msc_Extra_Amt_3")]
    public double? MscExtraAmt3 { get; set; }

    [Column("Extras_Stored_Material")]
    public double? ExtrasStoredMaterial { get; set; }

    [Column("Extras_Cost_At_Comp")]
    public double? ExtrasCostAtComp { get; set; }

    [Column("Extras_Cost_To_Comp")]
    public double? ExtrasCostToComp { get; set; }

    [Column("Extras_Lab_Hrs_To_Comp")]
    public double? ExtrasLabHrsToComp { get; set; }

    [Column("Extras_Msc_CC_Amt_5")]
    public double? ExtrasMscCcAmt5 { get; set; }

    [Column("Extras_Msc_CC_Amt_6")]
    public double? ExtrasMscCcAmt6 { get; set; }

    [Column("Extras_Msc_Cat_Amt_1")]
    public double? ExtrasMscCatAmt1 { get; set; }

    [Column("Extras_Msc_Cat_Amt_2")]
    public double? ExtrasMscCatAmt2 { get; set; }

    [Column("Extras_Msc_Cat_Amt_3")]
    public double? ExtrasMscCatAmt3 { get; set; }

    [Column("Extras_Msc_Cat_Amt_4")]
    public double? ExtrasMscCatAmt4 { get; set; }

    [Column("Extras_Custom_Total_1_Total")]
    public double? ExtrasCustomTotal1Total { get; set; }

    [Column("Extras_Custom_Total_2_Total")]
    public double? ExtrasCustomTotal2Total { get; set; }

    [Column("Extras_Custom_Total_3_Total")]
    public double? ExtrasCustomTotal3Total { get; set; }

    [Column("Extras_Custom_Total_4_Total")]
    public double? ExtrasCustomTotal4Total { get; set; }

    [Column("Extras_Custom_Total_5_Total")]
    public double? ExtrasCustomTotal5Total { get; set; }

    [Column("Extras_Custom_Total_6_Total")]
    public double? ExtrasCustomTotal6Total { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }

    [Column("Job_File_Links", TypeName = "text")]
    public string? JobFileLinks { get; set; }
}
