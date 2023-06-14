﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OEWebApplicationApp.Models;
using System.IO.Compression;
using System.IO;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OEWebApplicationApp.Controllers
{
    public class ImageController : Controller
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();
        ManagerImage ManagerImage = new();

        //IMAGE pull by request id================================================================================================
        public ActionResult Index(string id, string page)
        {
            ViewData["Page"] = page;
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            try
            {
                var OElist = ManagerImage.GetImages(id);
                if (!OElist.Any())
                {
                    TempData["Info Message"] = "-- Message Center: There are no images uploaded for this document " + id + " --";
                    OElist = ManagerImage.GetImages(id);
                    ViewData["MyRequestId"] = id;
                    return View(OElist);
                }
                else
                {
                    OElist = ManagerImage.GetImages(id);
                    ViewData["MyRequestId"] = id;
                    return View(OElist);
                }
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                ViewData["MyRequestId"] = id;
                return View();
            }
        }//Index

        //create image by id=====================================================================================================
        public IActionResult Create(string id, string page)
        {
            ViewData["Page"] = page;
            ViewData["MyRequestId"] = id;
            ImageModel model = new();
            return View(model);
        }


        [HttpPost]
        public IActionResult Create(ImageModel model)
        {
            model.IsResponse = true;
            //File Path============================================================================
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files");

            //create directory if not exist========================================================
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileInfo fileInfo = new FileInfo(model.File.FileName);

            if (!fileInfo.Exists)
            {
            //create a file name: requestid location (CGY EDM) DDMMYYYYHHMM=========================
                string dateTime = DateTime.Now.ToString("ddMMyyyyhhmmss");
                string extentsion = fileInfo.Extension;
                string fileName = model.RequestId + model.Location + dateTime  + fileInfo.Extension;
                string fileNameWithPath = Path.Combine(path, fileName);
                ViewData["MyPath"] = fileNameWithPath;
            //Copy file to the local system and check for pdf=======================================
                if(extentsion.ToLower() == ".pdf")
                    {
                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {
                            model.File.CopyTo(stream);
                            TempData["Info Message"] = "-- Message Center: File upload successfull --";
                        }
                        model.IsSuccess = true;
                        //update the database with location=================================================
                        ManagerImage.UpdateImageTbl(fileName, fileNameWithPath, model);
                        return RedirectToAction("Index", new { id = model.RequestId });
                    }
                    else
                    {
                        TempData["Info Message"] = "-- Message Center: Upload Failed - PDF only --";
                        return RedirectToAction("Index", new { id = model.RequestId });
                    }
            }
            else
            {
                TempData["Info Message"] = "-- Message Center: File upload NOT successfull --";
                return View("Index", new { id = model.RequestId });
            }
        }//Create

        //DELETE====================================================================================
        public IActionResult Delete(string id)
        {
            var OElist = ManagerImage.GetImage(id).FirstOrDefault();
            return View(OElist);
        }
        [HttpPost]
        public IActionResult Delete(string id, ImageModel imageModel)
        {
            try
            {
                string result = ManagerImage.DeleteImage(id, imageModel);
                if (result == "Success")
                {
                    TempData["Info Message"] = "-- Message Center: Image delete was Success --";
                    return RedirectToAction("Index", "Request");
                }
                else
                {
                    TempData["Info Message"] = "-- Message Center: Image Delete was NOT success --";
                    return RedirectToAction("Index","Request");
                }
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }


        }
    }//class
}//namespace
