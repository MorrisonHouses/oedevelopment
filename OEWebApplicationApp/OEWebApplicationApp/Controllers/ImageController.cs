using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OEWebApplicationApp.Models;
using System.IO.Compression;
using System.IO;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;

namespace OEWebApplicationApp.Controllers
{
    public class ImageController : Controller
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();
        ManagerImage ManagerImage = new();

        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }//Add
        public IActionResult ProfileController(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
            return View();
        }
        private IWebHostEnvironment _hostingEnvironment;

        [HttpPost]
        public IActionResult Add(ImageModel imageModel)
        {
            string serverImages = "\\\\Morfsdc1\\Users\\edoucett\\GitHub\\oedevelopment\\OEWebApplicationApp\\OEWebApplicationApp\\wwwroot\\Images\\";

            //string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string fileName = Path.GetFileName(imageModel.ImageFile.FileName);
            //string fileExtension = Path.GetExtension(imageModel.ImageFile.FileName);
            //fileName = fileName + DateTime.Now.ToString("g") + fileExtension;

            imageModel.ImageData = "~//wwwroot//Images//+fileName";
            var filepath = Path.Combine(_hostingEnvironment.WebRootPath, fileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                imageModel.ImageFile.CopyTo(stream);
            }
            
            //imageModel.ImageFile.CopyTo(filepath);
            return View("Add", imageModel);

        }//index


    }//class
}//namespace
