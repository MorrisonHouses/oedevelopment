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
        ManagerTblCgyoe tblCgyoeManager = new();

        // GET: =========================================================================
        public ActionResult Index(string id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            try
            {
                var OElist = tblCgyoeManager.GetViewApproverOERequest(id);
                if (!OElist.Any() )
                {
                    OElist = tblCgyoeManager.GetViewApproverOERequest(id);
                    TempData["Info Message"] = "-- Message Center: You do not have any approvals --";
                    return View(OElist);
                }
                else
                {
                    OElist = tblCgyoeManager.GetViewApproverOERequest(id);
                    return View(OElist);
                }
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }
           // var OElist = tblCgyoeManager.GetViewApproverOERequest(id);
            //return View(OElist);
        }

        // DETAILS: =========================================================================
        public ActionResult Details(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            try
            {
                var OElist = tblCgyoeManager.GetViewOEById(id);
                return View(OElist);
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }
            //var OElist = tblCgyoeManager.GetViewOEById(id);
            //return View(OElist);
        }

        // EDIT: =========================================================================
        public ActionResult Edit(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.status = tblCgyoeManager.StatusList();
            try
            {
                var OElist = tblCgyoeManager.GetViewOEById(id).FirstOrDefault();
                return View(OElist);
            }catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }

        }

        // POST: ApprovalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult Edit(int id, TblCgyoeModel TblCgyoeModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsUpdated = tblCgyoeManager.ApproveRequest(id, TblCgyoeModel);
                    if (IsUpdated)
                    {
                        TempData["Info Message"] = "--Message Center: Approval Success--";
                        //return RedirectToAction("Index", new { id = "notApproved" });
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Info Message"] = "--Message Center: Approval was NOT Success--";
                        //return RedirectToAction("Index", new { id = "notApproved" });
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                TempData["Info Message"] = ex.Message;
                return RedirectToAction("Index");
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
                TempData["Info Message"] = "--Message Center: Delete was success--";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Info Message"] = "--Message Center: Delete was NOT success--";
                return View();
            }
        }


    }//CLASS
}//NAMESPACE
