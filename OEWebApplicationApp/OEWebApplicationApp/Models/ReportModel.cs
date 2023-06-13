using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OEWebApplicationApp.Models
{
    public class ReportModel
    {
        [Key]

        [Column("RequestID")]
        [DisplayName("ID")]
        public int? RequestId { get; set; }
    }
}
