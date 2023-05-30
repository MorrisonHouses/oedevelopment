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
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OEWebApplicationApp.Controllers
{
    public class ApprovalController : Controller
    {
        //instace of helper classes======================================================
        TblCgyoeManager tblCgyoeManager = new();

        // GET: =========================================================================
        public ActionResult Index(string id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewApproverOERequest(id);
            return View(OElist);
        }

        // DETAILS: =========================================================================
        public ActionResult Details(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOEById(id);
            return View(OElist);
        }

        // EDIT: =========================================================================
        public ActionResult Edit(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.status = tblCgyoeManager.StatusList();
            var OElist = tblCgyoeManager.GetViewOEById(id).FirstOrDefault();

            return View(OElist);
        }

        // POST: ApprovalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TblCgyoeModel TblCgyoeModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsUpdated = tblCgyoeManager.ApproveRequest(id, TblCgyoeModel);
                    if (IsUpdated)
                    {
                        TempData["Info Message"] = "--Message Center: Updated Success--";
                        return RedirectToAction("Index", new { id = "notApproved" });
                    }
                    else
                    {
                        TempData["Info Message"] = "--Message Center: Updated was NOT Success--";
                        return RedirectToAction("Index", new { id = "notApproved" });
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

        // DELETE: =========================================================================
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApprovalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }//CLASS
}//NAMESPACE
