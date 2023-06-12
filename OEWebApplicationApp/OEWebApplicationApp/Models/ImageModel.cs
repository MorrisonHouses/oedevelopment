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
        public DateTime InsertDate { get; set; }
        [DisplayName("Location")]
        public string? Location { get; set; }
        [DisplayName("Upload File")]
        public string? Path { get; set; }

        //NOT MAPPED GETTERS AND SETTERS=======================================
        [FileExtensions(Extensions = "pdf, PDF")]
        [Required(ErrorMessage = "Please select file")]
        [NotMapped]
        public IFormFile ? File { get; set; }
        [NotMapped]
        public bool IsSuccess { get; set; }
        [NotMapped]
        public bool IsResponse { get; set; }
        [NotMapped]
        public string ? Message { get; set; }



    }//class
}//namespace
