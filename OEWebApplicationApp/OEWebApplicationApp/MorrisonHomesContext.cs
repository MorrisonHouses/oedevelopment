using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp;

public partial class MorrisonHomesContext : DbContext
{
    public MorrisonHomesContext()
    {
    }

    public MorrisonHomesContext(DbContextOptions<MorrisonHomesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<ReportCardResult> ReportCardResults { get; set; }

    public virtual DbSet<TblCgyoe> TblCgyoes { get; set; }

    public virtual DbSet<TblEdmoe> TblEdmoes { get; set; }

    public virtual DbSet<VendorExclusion> VendorExclusions { get; set; }

    public virtual DbSet<ViewAdUser> ViewAdUsers { get; set; }

    public virtual DbSet<ViewMorrisonEmployee> ViewMorrisonEmployees { get; set; }

    public virtual DbSet<ViewReportCardContact> ViewReportCardContacts { get; set; }

    public virtual DbSet<ViewReportCardResult> ViewReportCardResults { get; set; }

    public virtual DbSet<ViewReportCardResultsEdmonton> ViewReportCardResultsEdmontons { get; set; }

    public virtual DbSet<ViewReportCardResultsWithPo> ViewReportCardResultsWithPos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MORSQL;Initial Catalog=MorrisonHomes;User Id=bpm_user;Password=resu_mpb1; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Departments");

            entity.HasOne(d => d.Office).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Office");
        });

        modelBuilder.Entity<ReportCardResult>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblCgyoe>(entity =>
        {
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEdmoe>(entity =>
        {
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VendorExclusion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VendorException");
        });

        modelBuilder.Entity<ViewAdUser>(entity =>
        {
            entity.ToView("view_AD_Users");
        });

        modelBuilder.Entity<ViewMorrisonEmployee>(entity =>
        {
            entity.ToView("view_MorrisonEmployees");
        });

        modelBuilder.Entity<ViewReportCardContact>(entity =>
        {
            entity.ToView("view_ReportCardContacts");
        });

        modelBuilder.Entity<ViewReportCardResult>(entity =>
        {
            entity.ToView("view_ReportCardResults");
        });

        modelBuilder.Entity<ViewReportCardResultsEdmonton>(entity =>
        {
            entity.ToView("view_ReportCardResultsEdmonton");
        });

        modelBuilder.Entity<ViewReportCardResultsWithPo>(entity =>
        {
            entity.ToView("view_ReportCardResultsWithPO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
