using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

public partial class Employee
{
    [Key]
    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [Unicode(false)]
    public string? EmployeeFirstName { get; set; }

    [Unicode(false)]
    public string? EmployeeLastName { get; set; }

    [Unicode(false)]
    public string? EmployeeFullName { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [Column("OfficeID")]
    public int? OfficeId { get; set; }

    public bool? ReportCardEnable { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department? Department { get; set; }

    [ForeignKey("OfficeId")]
    [InverseProperty("Employees")]
    public virtual Office? Office { get; set; }
}
