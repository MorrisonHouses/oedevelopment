using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Table("VendorExclusion")]
public partial class VendorExclusion
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SupplierAPNumber")]
    [Unicode(false)]
    public string? SupplierApnumber { get; set; }

    [Unicode(false)]
    public string? SupplierName { get; set; }

    public bool? ExcludeVendor { get; set; }
}
