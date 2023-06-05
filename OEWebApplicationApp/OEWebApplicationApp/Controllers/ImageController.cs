using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OEWebApplicationApp.Models;
using System.IO.Compression;

namespace OEWebApplicationApp.Controllers
{
    public class ImageController : Controller
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();
        ManagerImage ManagerImage = new();

        public IActionResult Index()
        {
            return View();

        }//index

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Index(string id, ImageModel imageModel)
        {
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsUpdated = ManagerImage.UpdateRequest(id, imageModel);
                    if (IsUpdated)
                    {
                        TempData["Info Message"] = "--Message Center: Image Successfull--";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Info Message"] = "--Message Center: Image NOT Successfull--";
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }
        }



    }//class
}//namespace
