using Microsoft.AspNetCore.Components;

namespace OEWebApplicationApp.Models
{
    public class ViewGlaccountModel
    {

        public string? Account { get; set; }
        public string? AccountTitle { get; set; }
        public string? GateKeeper { get; set; }
        public double? ApprovalThreshold { get; set; }
        public string? ApprovalGateKeeper { get; set; }
    }
}
