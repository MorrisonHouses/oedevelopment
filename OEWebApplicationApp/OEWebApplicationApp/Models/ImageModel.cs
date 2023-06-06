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
        public string? ImageData { get; set; }
        public IFormFile ? ImageFile { get; set; }
        public string? Message { get; set; }
        public bool IsResponse { get; set; }
        public bool IsSuccess { get; set; }

        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; }
        [Required(ErrorMessage = "Please select file")]
        public IFormFile File { get; set; }



    }//class
}//namespace
