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
    public class RequestController : Controller
    {
        //instace of helper classes======================================================
        ClassFunctions function = new();
        ClassConfig configclass = new();
        TblCgyoeManager tblCgyoeManager = new();
        ApmMasterVendorManager apmMasterVendorManager = new();
        ViewGLaccountManager viewGLaccountManager = new();
        private readonly TblCgyoe? tblCGYoe;

        // GET: =========================================================================
        [Route("RequestedItemUser")]
        public ActionResult Index(string id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequest(id);
            return View(OElist);
        }


        // Details: =====================================================================
        [Route("DetailsItem/{id}")]
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
        //[Route("CreateItem")]
        public ActionResult Create()
        {
            //values from file==================================================
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.GstValue = configclass.ConfigGST();
            //dropdown list==================================================
            ViewBag.Budgeted = tblCgyoeManager.BudgetList();
            ViewBag.autoApproved = tblCgyoeManager.AutoApproveList();
            ViewBag.status = tblCgyoeManager.StatusList();
            ViewBag.gstInc = tblCgyoeManager.GstList();
            //total var======================================================
            ViewBag.ttlamt = 0;
            ViewBag.amount = 0;
            //ViewBag.threashold = 0;
            //select database lists==========================================
            TblCgyoeModel tblCgyoeModel = new TblCgyoeModel();
            string name = tblCgyoeModel.GetVendorName();
            string threashold = tblCgyoeModel.GetGlAccount();
            ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
            ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
            ViewBag.vendName = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == name);
            ViewBag.approverGK = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
            ViewBag.threashold = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == "1-0-1150");

            return View();
        }

        //Calculations: ===============================================================
        [HttpPost]
        [ActionName("Create")]
        public IActionResult Createcalc(TblCgyoeModel tblCgyoeModel)
        {
            //values from file==================================================
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.GstValue = configclass.ConfigGST();
            //dropdown list=====================================================
            ViewBag.Budgeted = tblCgyoeManager.BudgetList();
            ViewBag.autoApproved = tblCgyoeManager.AutoApproveList();
            ViewBag.status = tblCgyoeManager.StatusList();
            ViewBag.gstInc = tblCgyoeManager.GstList();
            //ViewBag.threashold = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == "1-0-1150");

            string name = tblCgyoeModel.GetVendorName();
            string threashold = tblCgyoeModel.GetGlAccount();

            if (ModelState.IsValid)
            {
                ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
                ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
                ViewBag.vendName = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == name);
                //ViewBag.threashold = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
                ViewBag.approverGK = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
                ViewBag.ttlamt = tblCgyoeModel.CalculateTotalValue();
                ViewBag.gstamt = tblCgyoeModel.CalculateGST();
                ViewBag.newAmt = tblCgyoeModel.CalculateAmount();
            }
            else
            {
                ViewBag.ttlamt = 0;
                ViewBag.gstamt = 0;
                ViewBag.newAmt = 0;
                ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
                ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
                //ViewBag.threashold = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
                ViewBag.vendName = "";
                ViewBag.approverGK = "";
            }
            return View(tblCgyoeModel);
        }

        //Createnew: ==================================================================
        // POST: RequestController/Create
        [HttpPost]
        [ActionName("CreateNew")]
        [ValidateAntiForgeryToken]
        public ActionResult Createupdate(TblCgyoe tblCgyoe)
        {
            bool IsUpdated = tblCgyoeManager.createProduct(tblCgyoe);
            return RedirectToAction("Index");

        }

        // edit: =====================================================================
        //[Route("EditItem/{id}")]
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
       // [Route("DeleteItem/{id}")]
        public ActionResult Delete(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();

            TblCgyoeModel model = new TblCgyoeModel();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequestById(id).FirstOrDefault();
            return View(OElist);
        }//Delete

        // POST: RequestController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(int id, TblCgyoe tblCgyoe)
        {
            string result = tblCgyoeManager.Delete(id);
            return RedirectToAction("Index");
            //try
            //{
            //    string result = tblCgyoeManager.Delete(id);
            //    return RedirectToAction("Index", new {id = "All"});
            //}
            //catch (Exception ex)
            //{

            //    TempData["Info Message"] = ex.Message;
            //    return View();
            //    }
        }//Delete
        // TEST: =====================================================================
        public IActionResult apm()
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == "AC002");
            //ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == "AC002");
            return View(OElist);

        }
        public IActionResult gls()
        {
            TblCgyoeModel model = new TblCgyoeModel();
            string threashold = model.GetGlAccount();
            var OElist = viewGLaccountManager.GetAllGlAccounts();
            return View(OElist);

        }

    }//class
}//namespace
