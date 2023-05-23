using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OEWebApplicationApp.Models
{
    public class ViewGlaccountModel
    {
        [Key]
        public string? Account { get; set; }
        public string? AccountTitle { get; set; }
        public string? GateKeeper { get; set; }
        public double? ApprovalThreshold { get; set; }
        public string? ApprovalGateKeeper { get; set; }


    }//class
}//namespace
