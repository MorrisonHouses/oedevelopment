using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OEWebApplicationApp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Identity.Client;
using Azure.Core;
using OEWebApplicationApp;
using Microsoft.Web.Administration;
using System.Security.Principal;
using System.Drawing;
using NuGet.Packaging.Signing;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OEWebApplicationApp.Controllers
{
    public class RequestController : Controller
    {
//instace of helper classes======================================================
        ClassFunctions function = new();
        ClassConfig configclass = new();
        TblCgyoeManager tblCgyoeManager = new();

        // GET: =========================================================================
        public ActionResult Index()
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequest();
            return View(OElist);
        }
        // Details: =====================================================================
        public ActionResult Details(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequestById(id);
            return View(OElist);
        }

        // Create: =====================================================================
        public ActionResult Create()
        {
            List<SelectListItem> Items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem() { Text = "Not Budgeted", Value = "false", Selected = true };
            SelectListItem item2 = new SelectListItem() { Text = "Budgeted", Value = "true", Selected = false };
            Items.Add(item1);
            Items.Add(item2);
            ViewBag.Budgeted = Items;

            List<SelectListItem> autoApproved = new List<SelectListItem>();
            SelectListItem autoApproved1 = new SelectListItem() { Text = "Not AutoApproved", Value = "false", Selected = true };
            SelectListItem autoApproved2 = new SelectListItem() { Text = "AutoApproved", Value = "true", Selected = false };
            autoApproved.Add(autoApproved1);
            autoApproved.Add(autoApproved2);
            ViewBag.autoApproved = autoApproved;

            return View();
        }

        // POST: RequestController/Create
        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblCgyoe tblCgyoe)
        {
            bool IsUpdated = tblCgyoeManager.createProduct(tblCgyoe);
            return RedirectToAction("Index");

        }

        // edit: =====================================================================
        public ActionResult Edit(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequestById(id).FirstOrDefault();
            return View(OElist);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit(int id, TblCgyoe tblCgyoe)
        {
            bool IsUpdated = tblCgyoeManager.UpdateRequest(id, tblCgyoe);
            return RedirectToAction("Index");


            //try
            //{
            //    if (ModelState.IsValid)
            //    {
            //        bool IsUpdated = tblCgyoeManager.UpdateRequest(tblCgyoe);
            //        if (IsUpdated)
            //        {
            //            TempData["Info Message"] = "updated success";
            //            return RedirectToAction("Index");
            //        }
            //        else
            //        {
            //            TempData["Info Message"] = "updated was not success";
            //            return RedirectToAction("Index");
            //        }
            //    }
            //    return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{

            //    TempData["Info Message"] = ex.Message;
            //    return View();
            //}

        }

        // Delete: =====================================================================
        public ActionResult Delete(int id)
        {
            var OElist = tblCgyoeManager.GetViewOERequestById(id).FirstOrDefault();
            return View(OElist);
        }

        // POST: RequestController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(int id, TblCgyoe tblCgyoe)
        {
            string result = tblCgyoeManager.Delete(id);
            return RedirectToAction("Index");


        }


    }//class
}//namespace
