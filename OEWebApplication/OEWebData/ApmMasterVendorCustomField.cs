using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class ApmMasterVendorCustomField
{
    [StringLength(10)]
    [Unicode(false)]
    public string Vendor { get; set; } = null!;

    [Column("Email_Address")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmailAddress { get; set; }

    [Column("Remittance_Method")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RemittanceMethod { get; set; }

    [Column("Financial_Institution")]
    [StringLength(25)]
    [Unicode(false)]
    public string? FinancialInstitution { get; set; }

    [Column("Institution_Street")]
    [StringLength(80)]
    [Unicode(false)]
    public string? InstitutionStreet { get; set; }

    [Column("Institution_City_Prov")]
    [StringLength(80)]
    [Unicode(false)]
    public string? InstitutionCityProv { get; set; }

    [Column("Institution_Postal_Code")]
    [StringLength(7)]
    [Unicode(false)]
    public string? InstitutionPostalCode { get; set; }

    [Column("Bank_Code", TypeName = "numeric(5, 0)")]
    public decimal? BankCode { get; set; }

    [Column("Transit_Number", TypeName = "numeric(10, 0)")]
    public decimal? TransitNumber { get; set; }

    [Column("Remittance_Fax_Number")]
    public double? RemittanceFaxNumber { get; set; }

    [Column("Account_Number")]
    [StringLength(12)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("Account_Number_950")]
    public double? AccountNumber950 { get; set; }

    [Column("Vendor_Custom_Fields_Nots", TypeName = "text")]
    public string? VendorCustomFieldsNots { get; set; }

    [Column("Vendor_Cstm_Flds_Fil_Lnks", TypeName = "text")]
    public string? VendorCstmFldsFilLnks { get; set; }
}
