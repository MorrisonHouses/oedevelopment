using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ViewReportCardContact
{
    [StringLength(10)]
    public string? Vendor { get; set; }

    [StringLength(255)]
    public string? TradeName { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? Province { get; set; }

    [StringLength(255)]
    public string? PostalCode { get; set; }

    [StringLength(511)]
    public string? ContactName { get; set; }

    [StringLength(255)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? Cellular { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }
}
