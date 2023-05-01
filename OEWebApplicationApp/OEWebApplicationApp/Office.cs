using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Table("Office")]
public partial class Office
{
    [Key]
    [Column("OfficeID")]
    public int OfficeId { get; set; }

    [Unicode(false)]
    public string? OfficeName { get; set; }

    [InverseProperty("Office")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
