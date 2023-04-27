using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OEWebApplication.Models;
using OEWebData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Configuration;
using System;
using System.IO;
using System.Globalization;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace OEWebApplication.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings    
        public ActionResult Index()
        {
            /*calls username, GST, CONFIG FILE LOCATION, USER ADDRESS*/
            Functions function = new();
            ConfigClass configclass = new();
            ViewBag.Address = configclass.Address();
            ViewBag.UserName = configclass.username();
            ViewBag.GST = configclass.ConfigGST();
            ViewBag.CONFLOC = configclass.ConfigLocation();
            ViewBag.EXPLOC = configclass.ExportLocation();
            ViewBag.DateTime = function.dateTime();
            return View();
        }// index

    }
}
