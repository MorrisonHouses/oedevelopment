using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OEWebData;

[Keyless]
public partial class GlmMasterAccount
{
    [StringLength(25)]
    [Unicode(false)]
    public string Account { get; set; } = null!;

    [Column("Account_Title")]
    [StringLength(40)]
    [Unicode(false)]
    public string AccountTitle { get; set; } = null!;

    [Column("Account_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string AccountType { get; set; } = null!;

    [Column("Store_Budgets")]
    public bool? StoreBudgets { get; set; }

    [Column("Store_Debit_Activity")]
    public bool? StoreDebitActivity { get; set; }

    [Column("Control_Account")]
    public bool? ControlAccount { get; set; }

    [Column("Allow_entry_in_GL")]
    public bool? AllowEntryInGl { get; set; }

    [Column("Summarize_Activity_Ledger")]
    public bool? SummarizeActivityLedger { get; set; }

    [Column("Intercompany_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IntercompanyStatus { get; set; }

    [Column("Owners_Account")]
    [StringLength(29)]
    [Unicode(false)]
    public string? OwnersAccount { get; set; }

    [Column("Control_Account_Type")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ControlAccountType { get; set; }

    [Column("Warning_Level")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WarningLevel { get; set; }

    [Column("Fiscal_Closing_Percent")]
    public double? FiscalClosingPercent { get; set; }

    [Column("Current_Balance")]
    public double? CurrentBalance { get; set; }

    [Column("Future_Balance")]
    public double? FutureBalance { get; set; }

    [Column("Balance_1_Year_Ago")]
    public double? Balance1YearAgo { get; set; }

    [Column("End_Balance_1_Year_Ago")]
    public double? EndBalance1YearAgo { get; set; }

    [Column("End_Balance_2_Years_Ago")]
    public double? EndBalance2YearsAgo { get; set; }

    [Column("End_Balance_3_Years_Ago")]
    public double? EndBalance3YearsAgo { get; set; }

    [Column("End_Balance_4_Years_Ago")]
    public double? EndBalance4YearsAgo { get; set; }

    [Column("End_Balance_5_Years_Ago")]
    public double? EndBalance5YearsAgo { get; set; }

    [Column("End_Balance_6_Years_Ago")]
    public double? EndBalance6YearsAgo { get; set; }

    [Column("End_Balance_7_Years_Ago")]
    public double? EndBalance7YearsAgo { get; set; }

    [Column("End_Balance_8_Years_Ago")]
    public double? EndBalance8YearsAgo { get; set; }

    [Column("End_Balance_9_Years_Ago")]
    public double? EndBalance9YearsAgo { get; set; }

    [Column("End_Balance_10_Years_Ago")]
    public double? EndBalance10YearsAgo { get; set; }

    [Column("Prior_Year_Adjustment")]
    public double? PriorYearAdjustment { get; set; }

    [Column("YTD_Net")]
    public double? YtdNet { get; set; }

    [Column("YTD_Net_1_Year_Ago")]
    public double? YtdNet1YearAgo { get; set; }

    [Column("Future_Activity_6")]
    public double? FutureActivity6 { get; set; }

    [Column("Future_Activity_5")]
    public double? FutureActivity5 { get; set; }

    [Column("Future_Activity_4")]
    public double? FutureActivity4 { get; set; }

    [Column("Future_Activity_3")]
    public double? FutureActivity3 { get; set; }

    [Column("Future_Activity_2")]
    public double? FutureActivity2 { get; set; }

    [Column("Future_Activity_1")]
    public double? FutureActivity1 { get; set; }

    [Column("Current_Period_Activity")]
    public double? CurrentPeriodActivity { get; set; }

    [Column("Prior_1_Activity")]
    public double? Prior1Activity { get; set; }

    [Column("Prior_2_Activity")]
    public double? Prior2Activity { get; set; }

    [Column("Prior_3_Activity")]
    public double? Prior3Activity { get; set; }

    [Column("Prior_4_Activity")]
    public double? Prior4Activity { get; set; }

    [Column("Prior_5_Activity")]
    public double? Prior5Activity { get; set; }

    [Column("Prior_6_Activity")]
    public double? Prior6Activity { get; set; }

    [Column("Prior_7_Activity")]
    public double? Prior7Activity { get; set; }

    [Column("Prior_8_Activity")]
    public double? Prior8Activity { get; set; }

    [Column("Prior_9_Activity")]
    public double? Prior9Activity { get; set; }

    [Column("Prior_10_Activity")]
    public double? Prior10Activity { get; set; }

    [Column("Prior_11_Activity")]
    public double? Prior11Activity { get; set; }

    [Column("Prior_12_Activity")]
    public double? Prior12Activity { get; set; }

    [Column("Year_Ago_Activity_1")]
    public double? YearAgoActivity1 { get; set; }

    [Column("Year_1_Period_1_Activity")]
    public double? Year1Period1Activity { get; set; }

    [Column("Year_1_Period_2_Activity")]
    public double? Year1Period2Activity { get; set; }

    [Column("Year_1_Period_3_Activity")]
    public double? Year1Period3Activity { get; set; }

    [Column("Year_1_Period_4_Activity")]
    public double? Year1Period4Activity { get; set; }

    [Column("Year_1_Period_5_Activity")]
    public double? Year1Period5Activity { get; set; }

    [Column("Year_1_Period_6_Activity")]
    public double? Year1Period6Activity { get; set; }

    [Column("Year_1_Period_7_Activity")]
    public double? Year1Period7Activity { get; set; }

    [Column("Year_1_Period_8_Activity")]
    public double? Year1Period8Activity { get; set; }

    [Column("Year_1_Period_9_Activity")]
    public double? Year1Period9Activity { get; set; }

    [Column("Year_1_Period_10_Activity")]
    public double? Year1Period10Activity { get; set; }

    [Column("Year_1_Period_11_Activity")]
    public double? Year1Period11Activity { get; set; }

    [Column("Year_1_Period_12_Activity")]
    public double? Year1Period12Activity { get; set; }

    [Column("YTD_Debits")]
    public double? YtdDebits { get; set; }

    [Column("YTD_Debit_1_Year_Ago")]
    public double? YtdDebit1YearAgo { get; set; }

    [Column("End_Debit_1_Year_Ago")]
    public double? EndDebit1YearAgo { get; set; }

    [Column("Future_Debit_Activity_6")]
    public double? FutureDebitActivity6 { get; set; }

    [Column("Future_Debit_Activity_5")]
    public double? FutureDebitActivity5 { get; set; }

    [Column("Future_Debit_Activity_4")]
    public double? FutureDebitActivity4 { get; set; }

    [Column("Future_Debit_Activity_3")]
    public double? FutureDebitActivity3 { get; set; }

    [Column("Future_Debit_Activity_2")]
    public double? FutureDebitActivity2 { get; set; }

    [Column("Future_Debit_Activity_1")]
    public double? FutureDebitActivity1 { get; set; }

    [Column("Debit_Activity")]
    public double? DebitActivity { get; set; }

    [Column("Prior_1_Debit_Activity")]
    public double? Prior1DebitActivity { get; set; }

    [Column("Prior_2_Debit_Activity")]
    public double? Prior2DebitActivity { get; set; }

    [Column("Prior_3_Debit_Activity")]
    public double? Prior3DebitActivity { get; set; }

    [Column("Prior_4_Debit_Activity")]
    public double? Prior4DebitActivity { get; set; }

    [Column("Prior_5_Debit_Activity")]
    public double? Prior5DebitActivity { get; set; }

    [Column("Prior_6_Debit_Activity")]
    public double? Prior6DebitActivity { get; set; }

    [Column("Prior_7_Debit_Activity")]
    public double? Prior7DebitActivity { get; set; }

    [Column("Prior_8_Debit_Activity")]
    public double? Prior8DebitActivity { get; set; }

    [Column("Prior_9_Debit_Activity")]
    public double? Prior9DebitActivity { get; set; }

    [Column("Prior_10_Debit_Activity")]
    public double? Prior10DebitActivity { get; set; }

    [Column("Prior_11_Debit_Activity")]
    public double? Prior11DebitActivity { get; set; }

    [Column("Prior_12_Debit_Activity")]
    public double? Prior12DebitActivity { get; set; }

    [Column("Debit_1_Year_Ago")]
    public double? Debit1YearAgo { get; set; }

    [Column("Debit_1_Yr_1_Per_Ago")]
    public double? Debit1Yr1PerAgo { get; set; }

    [Column("Debit_1_Yr_2_Per_Ago")]
    public double? Debit1Yr2PerAgo { get; set; }

    [Column("Debit_1_Yr_3_Per_Ago")]
    public double? Debit1Yr3PerAgo { get; set; }

    [Column("Debit_1_Yr_4_Per_Ago")]
    public double? Debit1Yr4PerAgo { get; set; }

    [Column("Debit_1_Yr_5_Per_Ago")]
    public double? Debit1Yr5PerAgo { get; set; }

    [Column("Debit_1_Yr_6_Per_Ago")]
    public double? Debit1Yr6PerAgo { get; set; }

    [Column("Debit_1_Yr_7_Per_Ago")]
    public double? Debit1Yr7PerAgo { get; set; }

    [Column("Debit_1_Yr_8_Per_Ago")]
    public double? Debit1Yr8PerAgo { get; set; }

    [Column("Debit_1_Yr_9_Per_Ago")]
    public double? Debit1Yr9PerAgo { get; set; }

    [Column("Debit_1_Yr_10_Per_Ago")]
    public double? Debit1Yr10PerAgo { get; set; }

    [Column("Debit_1_Yr_11_Per_Ago")]
    public double? Debit1Yr11PerAgo { get; set; }

    [Column("Debit_1_Yr_12_Per_Ago")]
    public double? Debit1Yr12PerAgo { get; set; }

    [Column("CCurrent_Balance")]
    public double? CcurrentBalance { get; set; }

    [Column("CFuture_Balance")]
    public double? CfutureBalance { get; set; }

    [Column("CBalance_1_Year_Ago")]
    public double? Cbalance1YearAgo { get; set; }

    [Column("CEnd_Balance_1_Yr_Ago")]
    public double? CendBalance1YrAgo { get; set; }

    [Column("CEnd_Balance_2_Yrs_Ago")]
    public double? CendBalance2YrsAgo { get; set; }

    [Column("CEnd_Balance_3_Yrs_Ago")]
    public double? CendBalance3YrsAgo { get; set; }

    [Column("CEnd_Balance_4_Yrs_Ago")]
    public double? CendBalance4YrsAgo { get; set; }

    [Column("CEnd_Balance_5_Yrs_Ago")]
    public double? CendBalance5YrsAgo { get; set; }

    [Column("CEnd_Balance_6_Yrs_Ago")]
    public double? CendBalance6YrsAgo { get; set; }

    [Column("CEnd_Balance_7_Yrs_Ago")]
    public double? CendBalance7YrsAgo { get; set; }

    [Column("CEnd_Balance_8_Yrs_Ago")]
    public double? CendBalance8YrsAgo { get; set; }

    [Column("CEnd_Balance_9_Yrs_Ago")]
    public double? CendBalance9YrsAgo { get; set; }

    [Column("CEnd_Balance_10_Yrs_Ago")]
    public double? CendBalance10YrsAgo { get; set; }

    [Column("CPrior_Year_Adjustment")]
    public double? CpriorYearAdjustment { get; set; }

    [Column("CYTD_Net")]
    public double? CytdNet { get; set; }

    [Column("CYTD_Net_1_Year")]
    public double? CytdNet1Year { get; set; }

    [Column("CFuture_Activity_6")]
    public double? CfutureActivity6 { get; set; }

    [Column("CFuture_Activity_5")]
    public double? CfutureActivity5 { get; set; }

    [Column("CFuture_Activity_4")]
    public double? CfutureActivity4 { get; set; }

    [Column("CFuture_Activity_3")]
    public double? CfutureActivity3 { get; set; }

    [Column("CFuture_Activity_2")]
    public double? CfutureActivity2 { get; set; }

    [Column("CFuture_Activity_1")]
    public double? CfutureActivity1 { get; set; }

    [Column("CCurrent_Period_Activity")]
    public double? CcurrentPeriodActivity { get; set; }

    [Column("CPrior_1_Activity")]
    public double? Cprior1Activity { get; set; }

    [Column("CPrior_2_Activity")]
    public double? Cprior2Activity { get; set; }

    [Column("CPrior_3_Activity")]
    public double? Cprior3Activity { get; set; }

    [Column("CPrior_4_Activity")]
    public double? Cprior4Activity { get; set; }

    [Column("CPrior_5_Activity")]
    public double? Cprior5Activity { get; set; }

    [Column("CPrior_6_Activity")]
    public double? Cprior6Activity { get; set; }

    [Column("CPrior_7_Activity")]
    public double? Cprior7Activity { get; set; }

    [Column("CPrior_8_Activity")]
    public double? Cprior8Activity { get; set; }

    [Column("CPrior_9_Activity")]
    public double? Cprior9Activity { get; set; }

    [Column("CPrior_10_Activity")]
    public double? Cprior10Activity { get; set; }

    [Column("CPrior_11_Activity")]
    public double? Cprior11Activity { get; set; }

    [Column("CPrior_12_Activity")]
    public double? Cprior12Activity { get; set; }

    [Column("C1_Year_Ago_Activity")]
    public double? C1YearAgoActivity { get; set; }

    [Column("CYr_1_Period_1_Activity")]
    public double? Cyr1Period1Activity { get; set; }

    [Column("CYr_1_Period_2_Activity")]
    public double? Cyr1Period2Activity { get; set; }

    [Column("CYr_1_Period_3_Activity")]
    public double? Cyr1Period3Activity { get; set; }

    [Column("CYr_1_Period_4_Activity")]
    public double? Cyr1Period4Activity { get; set; }

    [Column("CYr_1_Period_5_Activity")]
    public double? Cyr1Period5Activity { get; set; }

    [Column("CYr_1_Period_6_Activity")]
    public double? Cyr1Period6Activity { get; set; }

    [Column("CYr_1_Period_7_Activity")]
    public double? Cyr1Period7Activity { get; set; }

    [Column("CYr_1_Period_8_Activity")]
    public double? Cyr1Period8Activity { get; set; }

    [Column("CYr_1_Period_9_Activity")]
    public double? Cyr1Period9Activity { get; set; }

    [Column("CYr_1_Period_10_Activity")]
    public double? Cyr1Period10Activity { get; set; }

    [Column("CYr_1_Period_11_Activity")]
    public double? Cyr1Period11Activity { get; set; }

    [Column("CYr_1_Period_12_Activity")]
    public double? Cyr1Period12Activity { get; set; }

    [Column("CYTD_Debits")]
    public double? CytdDebits { get; set; }

    [Column("CYTD_Debit_1_Year_Ago")]
    public double? CytdDebit1YearAgo { get; set; }

    [Column("CEnd_Debit_1_Year_Ago")]
    public double? CendDebit1YearAgo { get; set; }

    [Column("CFuture_Debit_Activity_6")]
    public double? CfutureDebitActivity6 { get; set; }

    [Column("CFuture_Debit_Activity_5")]
    public double? CfutureDebitActivity5 { get; set; }

    [Column("CFuture_Debit_Activity_4")]
    public double? CfutureDebitActivity4 { get; set; }

    [Column("CFuture_Debit_Activity_3")]
    public double? CfutureDebitActivity3 { get; set; }

    [Column("CFuture_Debit_Activity_2")]
    public double? CfutureDebitActivity2 { get; set; }

    [Column("CFuture_Debit_Activity_1")]
    public double? CfutureDebitActivity1 { get; set; }

    [Column("CDebit_Activity")]
    public double? CdebitActivity { get; set; }

    [Column("CPrior_1_Debit_Activity")]
    public double? Cprior1DebitActivity { get; set; }

    [Column("CPrior_2_Debit_Activity")]
    public double? Cprior2DebitActivity { get; set; }

    [Column("CPrior_3_Debit_Activity")]
    public double? Cprior3DebitActivity { get; set; }

    [Column("CPrior_4_Debit_Activity")]
    public double? Cprior4DebitActivity { get; set; }

    [Column("CPrior_5_Debit_Activity")]
    public double? Cprior5DebitActivity { get; set; }

    [Column("CPrior_6_Debit_Activity")]
    public double? Cprior6DebitActivity { get; set; }

    [Column("CPrior_7_Debit_Activity")]
    public double? Cprior7DebitActivity { get; set; }

    [Column("CPrior_8_Debit_Activity")]
    public double? Cprior8DebitActivity { get; set; }

    [Column("CPrior_9_Debit_Activity")]
    public double? Cprior9DebitActivity { get; set; }

    [Column("CPrior_10_Debit_Activity")]
    public double? Cprior10DebitActivity { get; set; }

    [Column("CPrior_11_Debit_Activity")]
    public double? Cprior11DebitActivity { get; set; }

    [Column("CPrior_12_Debit_Activity")]
    public double? Cprior12DebitActivity { get; set; }

    [Column("CDebit_1_Year_Ago")]
    public double? Cdebit1YearAgo { get; set; }

    [Column("CDebit_1_Yr_1_Per_Ago")]
    public double? Cdebit1Yr1PerAgo { get; set; }

    [Column("CDebit_1_Yr_2_Per_Ago")]
    public double? Cdebit1Yr2PerAgo { get; set; }

    [Column("CDebit_1_Yr_3_Per_Ago")]
    public double? Cdebit1Yr3PerAgo { get; set; }

    [Column("CDebit_1_Yr_4_Per_Ago")]
    public double? Cdebit1Yr4PerAgo { get; set; }

    [Column("CDebit_1_Yr_5_Per_Ago")]
    public double? Cdebit1Yr5PerAgo { get; set; }

    [Column("CDebit_1_Yr_6_Per_Ago")]
    public double? Cdebit1Yr6PerAgo { get; set; }

    [Column("CDebit_1_Yr_7_Per_Ago")]
    public double? Cdebit1Yr7PerAgo { get; set; }

    [Column("CDebit_1_Yr_8_Per_Ago")]
    public double? Cdebit1Yr8PerAgo { get; set; }

    [Column("CDebit_1_Yr_9_Per_Ago")]
    public double? Cdebit1Yr9PerAgo { get; set; }

    [Column("CDebit_1_Yr_10_Per_Ago")]
    public double? Cdebit1Yr10PerAgo { get; set; }

    [Column("CDebit_1_Yr_11_Per_Ago")]
    public double? Cdebit1Yr11PerAgo { get; set; }

    [Column("CDebit_1_Yr_12_Per_Ago")]
    public double? Cdebit1Yr12PerAgo { get; set; }

    [Column("Operator_Stamp")]
    [StringLength(20)]
    [Unicode(false)]
    public string? OperatorStamp { get; set; }

    [Column("Date_Stamp", TypeName = "date")]
    public DateTime? DateStamp { get; set; }

    [Column("Time_Stamp")]
    [Precision(0)]
    public TimeSpan? TimeStamp { get; set; }

    [Column("Account_Notes", TypeName = "text")]
    public string? AccountNotes { get; set; }

    [Column("Account_File_Links", TypeName = "text")]
    public string? AccountFileLinks { get; set; }
}
