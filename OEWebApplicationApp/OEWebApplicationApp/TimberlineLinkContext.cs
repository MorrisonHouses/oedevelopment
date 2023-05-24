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

    public virtual DbSet<ApmMasterDistribution> ApmMasterDistributions { get; set; }

    public virtual DbSet<ApmMasterInvoice> ApmMasterInvoices { get; set; }

    public virtual DbSet<ApmMasterInvoice1> ApmMasterInvoices1 { get; set; }

    public virtual DbSet<ApmMasterInvoicePayment> ApmMasterInvoicePayments { get; set; }

    public virtual DbSet<ApmMasterVendor> ApmMasterVendors { get; set; }

    public virtual DbSet<ApmMasterVendorCustomField> ApmMasterVendorCustomFields { get; set; }

    public virtual DbSet<AptCurrentTransaction> AptCurrentTransactions { get; set; }

    public virtual DbSet<AptCurrentTransaction1> AptCurrentTransactions1 { get; set; }

    public virtual DbSet<ArmMasterCustomer> ArmMasterCustomers { get; set; }

    public virtual DbSet<ArtCurrentTransaction> ArtCurrentTransactions { get; set; }

    public virtual DbSet<GlmMasterAccount> GlmMasterAccounts { get; set; }

    public virtual DbSet<GlmMasterAccountCustomField> GlmMasterAccountCustomFields { get; set; }

    public virtual DbSet<JcmMasterCategory> JcmMasterCategories { get; set; }

    public virtual DbSet<JcmMasterCostCode> JcmMasterCostCodes { get; set; }

    public virtual DbSet<JcmMasterJob> JcmMasterJobs { get; set; }

    public virtual DbSet<JcmMasterJob1> JcmMasterJob1s { get; set; }

    public virtual DbSet<JcmMasterJob2> JcmMasterJob2s { get; set; }

    public virtual DbSet<JcmMasterJobCustomField> JcmMasterJobCustomFields { get; set; }

    public virtual DbSet<JcmMasterStandardCostCode> JcmMasterStandardCostCodes { get; set; }

    public virtual DbSet<JctCurrentTransaction> JctCurrentTransactions { get; set; }

    public virtual DbSet<JobCost> JobCosts { get; set; }

    public virtual DbSet<JobRevenue> JobRevenues { get; set; }

    public virtual DbSet<ViewGlaccount> ViewGlaccounts { get; set; }

    public virtual DbSet<ViewGlaccountsNew> ViewGlaccountsNews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VMORTL\\SQLEXPRESS;Database=TimberlineLink;User Id=ITMain;Password=M0rr1s0n1961; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApmMasterDistribution>(entity =>
        {
            entity.ToView("APM_Master_Distribution");
        });

        modelBuilder.Entity<ApmMasterInvoice>(entity =>
        {
            entity.ToView("APM_MASTER__INVOICE");
        });

        modelBuilder.Entity<ApmMasterInvoice1>(entity =>
        {
            entity.ToView("APM_Master_Invoice");
        });

        modelBuilder.Entity<ApmMasterInvoicePayment>(entity =>
        {
            entity.ToView("APM_MASTER__INVOICE_PAYMENT");
        });

        modelBuilder.Entity<ApmMasterVendor>(entity =>
        {
            entity.ToView("APM_Master_Vendor");
        });

        modelBuilder.Entity<ApmMasterVendorCustomField>(entity =>
        {
            entity.ToView("APM_MASTER__VENDOR_CUSTOM_FIELDS");
        });

        modelBuilder.Entity<AptCurrentTransaction>(entity =>
        {
            entity.ToView("APT_CURRENT__TRANSACTION");
        });

        modelBuilder.Entity<AptCurrentTransaction1>(entity =>
        {
            entity.ToView("APT_Current_Transaction");
        });

        modelBuilder.Entity<ArmMasterCustomer>(entity =>
        {
            entity.ToView("ARM_MASTER__CUSTOMER");
        });

        modelBuilder.Entity<ArtCurrentTransaction>(entity =>
        {
            entity.ToView("ART_CURRENT__TRANSACTION");
        });

        modelBuilder.Entity<GlmMasterAccount>(entity =>
        {
            entity.ToView("GLM_Master__Account");
        });

        modelBuilder.Entity<GlmMasterAccountCustomField>(entity =>
        {
            entity.ToView("GLM_Master_Account_Custom_Fields");
        });

        modelBuilder.Entity<JcmMasterCategory>(entity =>
        {
            entity.ToView("JCM_Master__CATEGORY");
        });

        modelBuilder.Entity<JcmMasterCostCode>(entity =>
        {
            entity.ToView("JCM_MASTER__COST_CODE");
        });

        modelBuilder.Entity<JcmMasterJob>(entity =>
        {
            entity.ToView("JCM_Master_Job");
        });

        modelBuilder.Entity<JcmMasterJob1>(entity =>
        {
            entity.ToView("JCM_Master_Job_1");
        });

        modelBuilder.Entity<JcmMasterJob2>(entity =>
        {
            entity.ToView("JCM_Master_Job_2");
        });

        modelBuilder.Entity<JcmMasterJobCustomField>(entity =>
        {
            entity.ToView("JCM_MASTER__JOB_CUSTOM_FIELDS");
        });

        modelBuilder.Entity<JcmMasterStandardCostCode>(entity =>
        {
            entity.ToView("JCM_Master__Standard_Cost_Code");
        });

        modelBuilder.Entity<JctCurrentTransaction>(entity =>
        {
            entity.ToView("JCT_CURRENT__TRANSACTION");
        });

        modelBuilder.Entity<JobCost>(entity =>
        {
            entity.ToView("Job_Cost");
        });

        modelBuilder.Entity<JobRevenue>(entity =>
        {
            entity.ToView("Job_Revenue");
        });

        modelBuilder.Entity<ViewGlaccount>(entity =>
        {
            entity.ToView("View_GLAccounts");
        });

        modelBuilder.Entity<ViewGlaccountsNew>(entity =>
        {
            entity.ToView("View_GLAccounts_new");

            entity.Property(e => e.Account).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            entity.Property(e => e.AccountTitle).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            entity.Property(e => e.ApprovalGateKeeper).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            entity.Property(e => e.GateKeeper).UseCollation("SQL_Latin1_General_CP1_CS_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<OEWebApplicationApp.Models.ViewGlaccountModel>? ViewGlaccountModel { get; set; }
}
