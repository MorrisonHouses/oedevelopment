using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class JcmMasterStandardCostCode
{
    [Column("Cost_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string CostCode { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Group_Cost_Code")]
    public bool GroupCostCode { get; set; }

    [Column("Accumulate_As")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AccumulateAs { get; set; }

    [Column("Cost_Account_A")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostAccountA { get; set; }

    [Column("Cost_Account_B")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostAccountB { get; set; }

    [Column("Cost_Account_C")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CostAccountC { get; set; }

    [Column("Overhead_Table")]
    [StringLength(8)]
    [Unicode(false)]
    public string? OverheadTable { get; set; }

    [Column("Production_Unit_Desc")]
    [StringLength(6)]
    [Unicode(false)]
    public string? ProductionUnitDesc { get; set; }

    [Column("Cost_Unit_Description")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CostUnitDescription { get; set; }

    [Column("Send_Cost_to_Billings")]
    public bool SendCostToBillings { get; set; }

    [Column("Use_Employee_Work_State")]
    public bool UseEmployeeWorkState { get; set; }

    [Column("Exempt_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string ExemptStatus { get; set; } = null!;

    [Column("Category_1")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category1 { get; set; }

    [Column("Unit_Description_1")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription1 { get; set; }

    [Column("Category_2")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category2 { get; set; }

    [Column("Unit_Description_2")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription2 { get; set; }

    [Column("Category_3")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category3 { get; set; }

    [Column("Unit_Description_3")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription3 { get; set; }

    [Column("Category_4")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category4 { get; set; }

    [Column("Unit_Description_4")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription4 { get; set; }

    [Column("Category_5")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category5 { get; set; }

    [Column("Unit_Description_5")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription5 { get; set; }

    [Column("Category_6")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category6 { get; set; }

    [Column("Unit_Description_6")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription6 { get; set; }

    [Column("Category_7")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category7 { get; set; }

    [Column("Unit_Description_7")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription7 { get; set; }

    [Column("Category_8")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category8 { get; set; }

    [Column("Unit_Description_8")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription8 { get; set; }

    [Column("Category_9")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category9 { get; set; }

    [Column("Unit_Description_9")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription9 { get; set; }

    [Column("Category_10")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category10 { get; set; }

    [Column("Unit_Description_10")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription10 { get; set; }

    [Column("Category_11")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category11 { get; set; }

    [Column("Unit_Description_11")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription11 { get; set; }

    [Column("Category_12")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Category12 { get; set; }

    [Column("Unit_Description_12")]
    [StringLength(6)]
    [Unicode(false)]
    public string? UnitDescription12 { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }
}
