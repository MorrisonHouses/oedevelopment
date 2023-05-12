using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OEWebApplicationApp.Models
{
    public class TblCgyoeModel
    {
        [Key]
        [Column("RequestID")]
        [DisplayName("ID")]
        public int? RequestId { get; set; }
        [DisplayName("Ven ID")]
        public string? Vendor { get; set; }
        [DisplayName("Vendor")]
        public string? VendorName { get; set; }
        [DisplayName("Created By")]
        public string? RequestedBy { get; set; }
        [DisplayName("GL")]
        public string? Glaccount { get; set; }
        public int? AutoApproveThreshold { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Amount")]
        public double? Amount { get; set; }
        [DisplayName("GST")]
        public double? Gstamount { get; set; }
        [UIHint("Currency")]
        [DisplayName("TTl Amt")]
        public double? TotalAmount { get; set; }
        public bool? Gstincluded { get; set; }
        public bool? Budgeted { get; set; }
        public bool? AutoApproved { get; set; }
        public string? Request { get; set; }
        [DisplayName("Purchase Date")]
        public DateTime? PurchaseDate { get; set; }
        [DisplayName("Approver")]
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? Status { get; set; }
        public string? Reason { get; set; }
        public byte[]? Attachment { get; set; }
        public DateTime? Timestamp { get; set; }

    }
}
