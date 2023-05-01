using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ArmMasterCustomer
{
    [StringLength(10)]
    [Unicode(false)]
    public string Customer { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("Customer_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string CustomerType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Trade { get; set; } = null!;

    [Column("Key_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Key1 { get; set; }

    [Column("Key_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Key2 { get; set; }

    [Column("Address_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("Address_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("Address_3")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [Column("Address_4")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(30)]
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
    public string? Telephone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("Email_Address")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmailAddress { get; set; }

    [Column("Date_Established", TypeName = "date")]
    public DateTime? DateEstablished { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column("GL_Prefix")]
    [StringLength(22)]
    [Unicode(false)]
    public string? GlPrefix { get; set; }

    [Column("Days_Before_Due", TypeName = "numeric(5, 0)")]
    public decimal? DaysBeforeDue { get; set; }

    [Column("Send_Statement")]
    public bool SendStatement { get; set; }

    [Column("PO_Required")]
    public bool PoRequired { get; set; }

    [Column("Credit_Limit")]
    public double? CreditLimit { get; set; }

    [Column("Credit_Rating")]
    [StringLength(20)]
    [Unicode(false)]
    public string CreditRating { get; set; } = null!;

    [Column("Accounts_Payabl")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AccountsPayabl { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Owner { get; set; }

    [Column("Contact_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact3 { get; set; }

    [Column("Contact_4")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact4 { get; set; }

    [Column("Contact_5")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact5 { get; set; }

    [Column("Contact_6")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact6 { get; set; }

    [Column("Contact_7")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact7 { get; set; }

    [Column("Contact_8")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact8 { get; set; }

    [Column("Contact_9")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact9 { get; set; }

    [Column("Contact_10")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Contact10 { get; set; }

    [Column("Billing_Address_1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillingAddress1 { get; set; }

    [Column("Billing_Address_2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillingAddress2 { get; set; }

    [Column("Billing_Address_3")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillingAddress3 { get; set; }

    [Column("Billing_Address_4")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillingAddress4 { get; set; }

    [Column("Billing_City")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BillingCity { get; set; }

    [Column("Billing_State")]
    [StringLength(4)]
    [Unicode(false)]
    public string? BillingState { get; set; }

    [Column("Billing_ZIP_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BillingZipCode { get; set; }

    [Column("Billing_Email_Address")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BillingEmailAddress { get; set; }

    [Column("Billing_Contact")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BillingContact { get; set; }

    [Column("Invoice_Format")]
    [StringLength(25)]
    [Unicode(false)]
    public string? InvoiceFormat { get; set; }

    [Column("SM_Invoice_Format")]
    [StringLength(255)]
    [Unicode(false)]
    public string? SmInvoiceFormat { get; set; }

    [Column("Billing_Freq")]
    [StringLength(20)]
    [Unicode(false)]
    public string BillingFreq { get; set; } = null!;

    public double? Retainage { get; set; }

    [Column("Auto_Text")]
    [StringLength(10)]
    [Unicode(false)]
    public string? AutoText { get; set; }

    [Column("Last_Auto_Number", TypeName = "numeric(10, 0)")]
    public decimal? LastAutoNumber { get; set; }

    [Column("Exempt_from_Finance_Charge")]
    public bool ExemptFromFinanceCharge { get; set; }

    [Column("Finance_Charge_Rate_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FinanceChargeRateType { get; set; }

    [Column("Finance_Charge_Percentage_Rate")]
    public double? FinanceChargePercentageRate { get; set; }

    [Column("Finance_Charge_Flat_Rate")]
    public double? FinanceChargeFlatRate { get; set; }

    [Column("Labor_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? LaborRateTable { get; set; }

    [Column("Material_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaterialRateTable { get; set; }

    [Column("Subcontract_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SubcontractRateTable { get; set; }

    [Column("Equipment_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EquipmentRateTable { get; set; }

    [Column("Overhead_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? OverheadRateTable { get; set; }

    [Column("Other_Rate_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? OtherRateTable { get; set; }

    [Column("Markup_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MarkupTable { get; set; }

    [Column("Addon_Table")]
    [StringLength(10)]
    [Unicode(false)]
    public string? AddonTable { get; set; }

    public double? Discount { get; set; }

    [Column("Total_Billed_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string TotalBilledExemptStatus { get; set; } = null!;

    [Column("Tax_Group")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TaxGroup { get; set; }

    [Column("Labor_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string LaborExemptStatus { get; set; } = null!;

    [Column("Material_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string MaterialExemptStatus { get; set; } = null!;

    [Column("Subcontract_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string SubcontractExemptStatus { get; set; } = null!;

    [Column("Equipment_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string EquipmentExemptStatus { get; set; } = null!;

    [Column("Overhead_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string OverheadExemptStatus { get; set; } = null!;

    [Column("Other_Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string OtherExemptStatus { get; set; } = null!;

    [Column("Resale_Cert")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ResaleCert { get; set; }

    [Column("ABN")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Abn { get; set; }

    [Column("st_Deposit_1")]
    public bool StDeposit1 { get; set; }

    [Column("Checklist_1_Date", TypeName = "date")]
    public DateTime? Checklist1Date { get; set; }

    [Column("nd_Deposit_2")]
    public bool NdDeposit2 { get; set; }

    [Column("Checklist_2_Date", TypeName = "date")]
    public DateTime? Checklist2Date { get; set; }

    [Column("Checklist_3")]
    public bool Checklist3 { get; set; }

    [Column("Checklist_3_Date", TypeName = "date")]
    public DateTime? Checklist3Date { get; set; }

    [Column("Checklist_4")]
    public bool Checklist4 { get; set; }

    [Column("Checklist_4_Date", TypeName = "date")]
    public DateTime? Checklist4Date { get; set; }

    [Column("Checklist_5")]
    public bool Checklist5 { get; set; }

    [Column("Checklist_5_Date", TypeName = "date")]
    public DateTime? Checklist5Date { get; set; }

    [Column("Checklist_6")]
    public bool Checklist6 { get; set; }

    [Column("Checklist_6_Date", TypeName = "date")]
    public DateTime? Checklist6Date { get; set; }

    [Column("Checklist_7")]
    public bool Checklist7 { get; set; }

    [Column("Checklist_7_Date", TypeName = "date")]
    public DateTime? Checklist7Date { get; set; }

    [Column("Checklist_8")]
    public bool Checklist8 { get; set; }

    [Column("Checklist_8_Date", TypeName = "date")]
    public DateTime? Checklist8Date { get; set; }

    [Column("Checklist_9")]
    public bool Checklist9 { get; set; }

    [Column("Checklist_9_Date", TypeName = "date")]
    public DateTime? Checklist9Date { get; set; }

    [Column("Checklist_10")]
    public bool Checklist10 { get; set; }

    [Column("Checklist_10_Date", TypeName = "date")]
    public DateTime? Checklist10Date { get; set; }

    [Column("Statement_Msg")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StatementMsg { get; set; }

    [Column("Statement_Text")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StatementText { get; set; }

    [Column("Text_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Text3 { get; set; }

    [Column("Text_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Text4 { get; set; }

    [Column("Text_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Text5 { get; set; }

    [Column("Text_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Text6 { get; set; }

    [Column("AB_Company_ID")]
    [StringLength(36)]
    [Unicode(false)]
    public string? AbCompanyId { get; set; }

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

    [Column("Customer_Notes", TypeName = "text")]
    public string? CustomerNotes { get; set; }

    [Column("Customer_File_Links", TypeName = "text")]
    public string? CustomerFileLinks { get; set; }
}
