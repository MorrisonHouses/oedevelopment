using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OEWebApplicationApp.Models
{
    public class TblCgyoeModel
    {
        [Key]
        public int? RequestId { get; set; }

        public string? Vendor { get; set; }

        public string? VendorName { get; set; }
        public string? RequestedBy { get; set; }
        public string? Glaccount { get; set; }
        public int? AutoApproveThreshold { get; set; }
        public double? Amount { get; set; }
        public double? Gstamount { get; set; }
        public double? TotalAmount { get; set; }
        public bool? Gstincluded { get; set; }
        public bool? Budgeted { get; set; }
        public bool? AutoApproved { get; set; }
        public string? Request { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? Status { get; set; }
        public string? Reason { get; set; }
        public byte[]? Attachment { get; set; }
        public DateTime? Timestamp { get; set; }

    }
}
