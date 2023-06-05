using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using static OEWebApplicationApp.ManagerImage;

namespace OEWebApplicationApp.Models
{
    public class ImageModel
    {

        [Key]
        public int Id { get; set; }

        [Column("RequestID")]
        [DisplayName("ID")]
        public int? RequestId { get; set; }

        public string? Name { get; set; }
        public int? Size { get; set; }
        public byte[]? ImageData { get; set; }


    }//class
}//namespace
