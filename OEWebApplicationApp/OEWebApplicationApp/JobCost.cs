using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class JobCost
{
    [StringLength(12)]
    [Unicode(false)]
    public string? Job { get; set; }

    public double? Estimate { get; set; }

    [Column("WipJTDCost")]
    public double? WipJtdcost { get; set; }

    [Column("JTDCost")]
    public double? Jtdcost { get; set; }

    [Column("NMCost")]
    public double? Nmcost { get; set; }

    [Column("JTDPaid")]
    public double? Jtdpaid { get; set; }

    [Column(TypeName = "date")]
    public DateTime? LastCostUpdate { get; set; }
}
