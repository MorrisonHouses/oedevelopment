using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class GlmMasterAccountCustomField
{
    [Column("Account_Custom_Field")]
    [StringLength(25)]
    [Unicode(false)]
    public string AccountCustomField { get; set; } = null!;

    [Column("Gate_Keeper")]
    [StringLength(15)]
    [Unicode(false)]
    public string? GateKeeper { get; set; }

    [Column("Approval_Threshold")]
    public double? ApprovalThreshold { get; set; }

    [Column("Approval_Gate_Keeper")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ApprovalGateKeeper { get; set; }
}
