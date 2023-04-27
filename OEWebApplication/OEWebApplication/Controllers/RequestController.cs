﻿using Microsoft.AspNetCore.Mvc;
using OEWebData;

namespace OEWebApplication.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            Functions function = new();
            ConfigClass configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            return View();
        }
    }
}
