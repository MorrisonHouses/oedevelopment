using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ViewMorrisonEmployee
{
    [Unicode(false)]
    public string? Employee { get; set; }

    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [Unicode(false)]
    public string? OfficeName { get; set; }

    public bool? ReportCardEnable { get; set; }
}
