using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [DisplayName("Amount")]
        public double? Amount { get; set; }
        [DisplayName("GST %")]
        [DataType(DataType.Currency)]
        public double? Gstvalue{get; set;}
        [DisplayName("GST Amt")]
        public double? Gstamount { get; set; }
        //[UIHint("Currency")]
        [DataType(DataType.Currency)]
        [DisplayName("Total Amt")]
        public double? TotalAmount { get; set; }
        [DisplayName("GST Included")]
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


        //Create page =================================================================

        public string? GetVendorName()
        {
            if (Vendor == null)
            {
                return "null";
            }
            else
            {
                return Vendor;
            }
        }

        //calculation on the create page GST/AMOUNT/TOTAL AMOUNT=======================
        public double? CalculateTotalValue()
        {
            if (Gstincluded == false)
            {
                double? totalAmount = Math.Round((double)((Amount * (Gstvalue / 100)) + Amount),2);
                return totalAmount;
            }
            else 
            {
                double? totalAmount = Math.Round((double)((((100 - Gstvalue) * Amount) / 100) + Gstamount),2);
                return totalAmount; 
            }
        }//CalculateTotalValue
        public double? CalculateGST()
        {
            if (Gstincluded == false)
            {
                double? gstAmount = Math.Round((double)((Amount * Gstvalue) / 100)   ,2) ;
                return gstAmount;
            }
            else 
            {
                double? gstAmount = Math.Round((double)(Amount-(Amount / (Gstvalue + 100)*100) ),2);
                return gstAmount;
            }
        }
        public double? CalculateAmount()
        {
            if (Gstincluded == false)
            {
                double? newAmount = Amount;
                return newAmount;
            }
            else
            {
                double? newAmount = Math.Round((double)((Amount / (Gstvalue + 100) * 100)) ,2)  ;
                return newAmount;
            }
                
        }

    }//class
}//namespace
