using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class ViewGlaccountsNew
{
    [StringLength(30)]
    public string? Account { get; set; }

    [Column("Account_Title")]
    [StringLength(45)]
    public string? AccountTitle { get; set; }

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
