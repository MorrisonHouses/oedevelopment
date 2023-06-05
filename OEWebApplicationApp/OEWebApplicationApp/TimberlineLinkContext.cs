using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OEWebApplicationApp.Models;

namespace OEWebApplicationApp;

public partial class TimberlineLinkContext : DbContext
{
    public TimberlineLinkContext()
    {
    }

    public TimberlineLinkContext(DbContextOptions<TimberlineLinkContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VMORTL\\SQLEXPRESS;Database=TimberlineLink;User Id=ITMain;Password=M0rr1s0n1961; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<OEWebApplicationApp.Models.ViewGlaccountModel>? ViewGlaccountModel { get; set; }
}
