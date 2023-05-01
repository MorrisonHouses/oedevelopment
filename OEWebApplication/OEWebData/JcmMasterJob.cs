using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class JcmMasterJob
{
    [StringLength(10)]
    [Unicode(false)]
    public string Job { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Address_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("Address_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("ZIP_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? Size { get; set; }

    [Column("Unit_Description")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription { get; set; }

    [Column("Security_ID")]
    [StringLength(38)]
    [Unicode(false)]
    public string? SecurityId { get; set; }

    [Column("Site_Phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SitePhone { get; set; }

    [Column("Fax_Phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FaxPhone { get; set; }

    [Column("Misc_Phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MiscPhone { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Lot { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Block { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Phase { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Plan { get; set; }

    [Column("Misc_Title_4")]
    [StringLength(30)]
    [Unicode(false)]
    public string? MiscTitle4 { get; set; }

    [Column("Project_Manager_Email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectManagerEmail { get; set; }

    [Column("Superintendent_Email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SuperintendentEmail { get; set; }

    [Column("User_Def_Key_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? UserDefKey1 { get; set; }

    [Column("User_Def_Key_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? UserDefKey2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("Use_PJ_Change_Management")]
    public bool UsePjChangeManagement { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Extras { get; set; }

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

    [Column("Actual_Complete_Date", TypeName = "datetime")]
    public DateTime? ActualCompleteDate { get; set; }

    [Column("Last_Cost_Update", TypeName = "date")]
    public DateTime? LastCostUpdate { get; set; }

    [Column("Checklist_2")]
    public bool Checklist2 { get; set; }

    [Column("Checklist_3")]
    public bool Checklist3 { get; set; }

    [Column("Checklist_4")]
    public bool Checklist4 { get; set; }

    [Column("Checklist_5")]
    public bool Checklist5 { get; set; }

    [Column("Checklist_6")]
    public bool Checklist6 { get; set; }

    [Column("Checklist_7")]
    public bool Checklist7 { get; set; }

    [Column("Checklist_8")]
    public bool Checklist8 { get; set; }

    [Column("Checklist_9")]
    public bool Checklist9 { get; set; }

    [Column("Checklist_10")]
    public bool Checklist10 { get; set; }

    [Column("Checklist_11")]
    public bool Checklist11 { get; set; }

    [Column("Checklist_12")]
    public bool Checklist12 { get; set; }

    [Column("AR_Customer")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ArCustomer { get; set; }

    [Column("Job_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? JobTaxGroup { get; set; }

    [Column("Billing_Method")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BillingMethod { get; set; }

    [Column("Billing_Level")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BillingLevel { get; set; }

    [Column("Revenue_Account")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RevenueAccount { get; set; }

    [Column("Retainage_Percent")]
    public double? RetainagePercent { get; set; }

    [Column("Exempt_from_Finance_Charge")]
    public bool ExemptFromFinanceCharge { get; set; }

    [Column("Finance_Charge_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FinanceChargeType { get; set; }

    [Column("Finance_Charge_Percentage")]
    public double? FinanceChargePercentage { get; set; }

    [Column("Finance_Charge_Flat_Rate")]
    public double? FinanceChargeFlatRate { get; set; }

    [Column("Scope_of_Work")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ScopeOfWork { get; set; }

    [Column("Daily_Entry_Control")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DailyEntryControl { get; set; }

    [Column("Workers_Comp_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? WorkersCompGroup { get; set; }

    [Column("Burden_Percent")]
    public double? BurdenPercent { get; set; }

    [Column("Work_State")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WorkState { get; set; }

    [Column("Work_Local")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WorkLocal { get; set; }

    [Column("Default_Revenue_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? DefaultRevenueCode { get; set; }

    [Column("Certified_Project")]
    [StringLength(21)]
    [Unicode(false)]
    public string? CertifiedProject { get; set; }

    [Column("On_Hold")]
    public bool OnHold { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Authorization { get; set; }

    [Column("Bank_Account")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [Column("Labor_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? LaborTaxGroup { get; set; }

    [Column("Material_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? MaterialTaxGroup { get; set; }

    [Column("Subcontract_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? SubcontractTaxGroup { get; set; }

    [Column("Equipment_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? EquipmentTaxGroup { get; set; }

    [Column("Overhead_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? OverheadTaxGroup { get; set; }

    [Column("Other_Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? OtherTaxGroup { get; set; }

    [Column("Cost_Account_Group")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CostAccountGroup { get; set; }

    [Column("Cost_Account_Prefix")]
    [StringLength(22)]
    [Unicode(false)]
    public string? CostAccountPrefix { get; set; }

    [Column("Cost_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostAccount { get; set; }

    [Column("Cost_of_Sales_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostOfSalesAccount { get; set; }

    [Column("Full_Revenue_Account")]
    [StringLength(25)]
    [Unicode(false)]
    public string? FullRevenueAccount { get; set; }

    [Column("Revenue_Recog_Method")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RevenueRecogMethod { get; set; }

    [Column("Produce_Vendor_Type_1_Lien_Waiver")]
    public bool ProduceVendorType1LienWaiver { get; set; }

    [Column("Use_Vendor_Type_1_Commitment_LW_Amount")]
    public bool UseVendorType1CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_1_Commitment_LW_Amount")]
    public double? MinVendorType1CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_1_LW_Amount")]
    public double? MinVendorType1LwAmount { get; set; }

    [Column("Req_Vendor_Type_1_Certified_Rpts")]
    public bool ReqVendorType1CertifiedRpts { get; set; }

    [Column("Req_Vendor_Type_1_Master_Approval")]
    public bool ReqVendorType1MasterApproval { get; set; }

    [Column("Produce_Vendor_Type_2_Lien_Waiver")]
    public bool ProduceVendorType2LienWaiver { get; set; }

    [Column("Use_Vendor_Type_2_Commitment_LW_Amount")]
    public bool UseVendorType2CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_2_Commitment_LW_Amount")]
    public double? MinVendorType2CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_2_LW_Amount")]
    public double? MinVendorType2LwAmount { get; set; }

    [Column("Req_Vendor_Type_2_Certified_Rpts")]
    public bool ReqVendorType2CertifiedRpts { get; set; }

    [Column("Req_Vendor_Type_2_Master_Approval")]
    public bool ReqVendorType2MasterApproval { get; set; }

    [Column("Produce_Vendor_Type_3_Lien_Waiver")]
    public bool ProduceVendorType3LienWaiver { get; set; }

    [Column("Use_Vendor_Type_3_Commitment_LW_Amount")]
    public bool UseVendorType3CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_3_Commitment_LW_Amount")]
    public double? MinVendorType3CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_3_LW_Amount")]
    public double? MinVendorType3LwAmount { get; set; }

    [Column("Req_Vendor_Type_3_Certified_Rpts")]
    public bool ReqVendorType3CertifiedRpts { get; set; }

    [Column("Req_Vendor_Type_3_Master_Approval")]
    public bool ReqVendorType3MasterApproval { get; set; }

    [Column("Produce_Vendor_Type_4_Lien_Waiver")]
    public bool ProduceVendorType4LienWaiver { get; set; }

    [Column("Use_Vendor_Type_4_Commitment_LW_Amount")]
    public bool UseVendorType4CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_4_Commitment_LW_Amount")]
    public double? MinVendorType4CommitmentLwAmount { get; set; }

    [Column("Min_Vendor_Type_4_LW_Amount")]
    public double? MinVendorType4LwAmount { get; set; }

    [Column("Req_Vendor_Type_4_Certified_Rpts")]
    public bool ReqVendorType4CertifiedRpts { get; set; }

    [Column("Req_Vendor_Type_4_Master_Approval")]
    public bool ReqVendorType4MasterApproval { get; set; }

    [Column("Last_Day_of_Month")]
    public byte LastDayOfMonth { get; set; }

    [Column("LW_Conditional_Thru_Date")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LwConditionalThruDate { get; set; }

    [Column("LW_Uncond_Thru_Date")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LwUncondThruDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Jurisdiction { get; set; }

    [Column("Cert_Rpt_Week_Ending_Day")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CertRptWeekEndingDay { get; set; }

    [Column("Master_Cmplnc_Tolerance")]
    public double? MasterCmplncTolerance { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [Column("Customer_Name")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [Column("Customer_Address_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerAddress1 { get; set; }

    [Column("Customer_Address_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerAddress2 { get; set; }

    [Column("Customer_City")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerCity { get; set; }

    [Column("Customer_State")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CustomerState { get; set; }

    [Column("Customer_ZIP_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerZipCode { get; set; }

    [Column("Customer_Contact_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerContact1 { get; set; }

    [Column("Customer_Phone_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerPhone1 { get; set; }

    [Column("Customer_FAX")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerFax { get; set; }

    [Column("Bill_to_Address_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillToAddress1 { get; set; }

    [Column("Bill_to_Address_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillToAddress2 { get; set; }

    [Column("Bill_to_city")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BillToCity { get; set; }

    [Column("Bill_to_state")]
    [StringLength(4)]
    [Unicode(false)]
    public string? BillToState { get; set; }

    [Column("Bill_to_ZIP_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BillToZipCode { get; set; }

    [Column("Customer_Contact_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerContact2 { get; set; }

    [Column("Customer_Phone_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerPhone2 { get; set; }

    [Column("Owner_Contract_ID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? OwnerContractId { get; set; }

    [Column("Contract_Date", TypeName = "datetime")]
    public DateTime? ContractDate { get; set; }

    [Column("Contract_Retainage_Percent")]
    public double? ContractRetainagePercent { get; set; }

    [Column("Contract_Type")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ContractType { get; set; }

    [Column("Original_Contract_Amount")]
    public double? OriginalContractAmount { get; set; }

    [Column("Potential_CO_Contract_Changes")]
    public double? PotentialCoContractChanges { get; set; }

    [Column("CO_Request_Contract_Changes")]
    public double? CoRequestContractChanges { get; set; }

    [Column("Verbal_Okay_Contract_Changes")]
    public double? VerbalOkayContractChanges { get; set; }

    [Column("JTD_Aprvd_Contract_Chgs")]
    public double? JtdAprvdContractChgs { get; set; }

    [Column("Revised_Contract_Amount")]
    public double? RevisedContractAmount { get; set; }

    [Column("YTD_Aprvd_Contract_Chgs")]
    public double? YtdAprvdContractChgs { get; set; }

    [Column("QTD_Aprvd_Contract_Chgs")]
    public double? QtdAprvdContractChgs { get; set; }

    [Column("MTD_Aprvd_Contract_Chgs")]
    public double? MtdAprvdContractChgs { get; set; }

    [Column("LM_Aprvd_Contract_Chgs")]
    public double? LmAprvdContractChgs { get; set; }

    [Column("NM_Aprvd_Contract_Chgs")]
    public double? NmAprvdContractChgs { get; set; }

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

    [Column("JTD_Payments")]
    public double? JtdPayments { get; set; }

    [Column("YTD_Payments")]
    public double? YtdPayments { get; set; }

    [Column("QTD_Payments")]
    public double? QtdPayments { get; set; }

    [Column("MTD_Payments")]
    public double? MtdPayments { get; set; }

    [Column("LM_Payments")]
    public double? LmPayments { get; set; }

    [Column("NM_Payments")]
    public double? NmPayments { get; set; }

    [Column("JTD_Adjustment")]
    public double? JtdAdjustment { get; set; }

    [Column("YTD_Adjustment")]
    public double? YtdAdjustment { get; set; }

    [Column("QTD_Adjustment")]
    public double? QtdAdjustment { get; set; }

    [Column("MTD_Adjustment")]
    public double? MtdAdjustment { get; set; }

    [Column("LM_Adjustment")]
    public double? LmAdjustment { get; set; }

    [Column("NM_Adjustment")]
    public double? NmAdjustment { get; set; }

    [Column("Receivable_Balance")]
    public double? ReceivableBalance { get; set; }

    [Column("Last_Draw")]
    [StringLength(15)]
    [Unicode(false)]
    public string? LastDraw { get; set; }

    [Column("Orig_Estimate_Finalized")]
    public bool OrigEstimateFinalized { get; set; }

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

    [Column("Total_Tax_Amount")]
    public double? TotalTaxAmount { get; set; }

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

    [Column("Total_Overhead_Estimate")]
    public double? TotalOverheadEstimate { get; set; }

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

    [Column("Job_Notes", TypeName = "text")]
    public string? JobNotes { get; set; }

    [Column("Job_File_Links", TypeName = "text")]
    public string? JobFileLinks { get; set; }
}
