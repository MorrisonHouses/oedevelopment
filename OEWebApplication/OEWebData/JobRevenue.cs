using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class JobRevenue
{
    [StringLength(10)]
    [Unicode(false)]
    public string Customer { get; set; } = null!;

    public double? Amount { get; set; }
}
