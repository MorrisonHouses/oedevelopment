using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

[Keyless]
public partial class ViewAdUser
{
    [Column("displayName")]
    [StringLength(4000)]
    public string? DisplayName { get; set; }

    [Column("sAMAccountName")]
    [StringLength(4000)]
    public string? SAmaccountName { get; set; }

    [Column("userPrincipalName")]
    [StringLength(4000)]
    public string? UserPrincipalName { get; set; }

    [Column("sn")]
    [StringLength(4000)]
    public string? Sn { get; set; }

    [Column("givenName")]
    [StringLength(4000)]
    public string? GivenName { get; set; }

    [Column("title")]
    [StringLength(4000)]
    public string? Title { get; set; }

    [Column("department")]
    [StringLength(4000)]
    public string? Department { get; set; }

    [Column("mail")]
    [StringLength(4000)]
    public string? Mail { get; set; }

    [Column("ipPhone")]
    [StringLength(4000)]
    public string? IpPhone { get; set; }

    [Column("employeeNumber")]
    [StringLength(4000)]
    public string? EmployeeNumber { get; set; }

    [Column("telephoneNumber")]
    [StringLength(4000)]
    public string? TelephoneNumber { get; set; }

    [Column("mobile")]
    [StringLength(4000)]
    public string? Mobile { get; set; }

    [Column("facsimileTelephoneNumber")]
    [StringLength(4000)]
    public string? FacsimileTelephoneNumber { get; set; }

    [Column("info")]
    [StringLength(4000)]
    public string? Info { get; set; }

    [Column("distinguishedName")]
    [StringLength(4000)]
    public string? DistinguishedName { get; set; }

    [Column("accountexpires", TypeName = "datetime")]
    public DateTime? Accountexpires { get; set; }

    [Column("lockoutTime", TypeName = "datetime")]
    public DateTime? LockoutTime { get; set; }

    [Column("badPasswordTime", TypeName = "datetime")]
    public DateTime? BadPasswordTime { get; set; }

    [Column("pwdLastSet", TypeName = "datetime")]
    public DateTime? PwdLastSet { get; set; }

    [Column("lastLogon", TypeName = "datetime")]
    public DateTime? LastLogon { get; set; }

    [Column("lastLogoff", TypeName = "datetime")]
    public DateTime? LastLogoff { get; set; }

    [Column("logonCount")]
    public int? LogonCount { get; set; }

    [Column("msExchMailboxGuid")]
    public Guid? MsExchMailboxGuid { get; set; }

    [Column("objectSID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ObjectSid { get; set; }
}
