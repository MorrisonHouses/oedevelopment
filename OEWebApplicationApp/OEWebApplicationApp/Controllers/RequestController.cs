﻿using Microsoft.AspNetCore.Http;
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
using System.Reflection.Emit;


namespace OEWebApplicationApp.Controllers
{
    public class RequestController : Controller
    {
        //instace of helper classes======================================================
        ClassFunctions function = new();
        ClassConfig configclass = new();
        ManagerTblCgyoe tblCgyoeManager = new();
        ManagerApmMasterVendor apmMasterVendorManager = new();
        ManagerViewGLaccount viewGLaccountManager = new();
        private readonly TblCgyoeModel? tblCGYoe;

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
            ViewBag.gstamt = 0;
            //select database lists==========================================
            TblCgyoeModel tblCgyoeModel = new TblCgyoeModel();
            string name = tblCgyoeModel.GetVendorName();
            string threashold = tblCgyoeModel.GetGlAccount();
            ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
            ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
            ViewBag.vendName = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == name);
            ViewBag.approverGK = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);


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

            string name = tblCgyoeModel.GetVendorName();
            string threashold = tblCgyoeModel.GetGlAccount();

            if (ModelState.IsValid)
            {
                ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
                ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
                ViewBag.vendName = apmMasterVendorManager.GetViewVendor().ToList().Where(x => x.Vendor == name);
                ViewBag.threashold = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
                ViewBag.approverGK = viewGLaccountManager.GetAllGlAccounts().ToList().Where(x => x.AccountCustomField == threashold);
                ViewBag.gstamt = tblCgyoeModel.CalculateGST();
                ViewBag.ttlamt = tblCgyoeModel.CalculateTotalValue();
                ViewBag.newAmt = tblCgyoeModel.CalculateAmount();

            }
            else
            {
                ViewBag.ttlamt = 0;
                ViewBag.gstamt = 0;
                ViewBag.newAmt = 0;
                ViewBag.vendors = apmMasterVendorManager.GetViewVendor().ToList();
                ViewBag.glAccounts = viewGLaccountManager.GetAllGlAccounts();
                ViewBag.vendName = "";
                ViewBag.approverGK = "";
            }
            return View(tblCgyoeModel);
        }

        //Createnew: ==================================================================
        [HttpPost]
        [ActionName("CreateNew")]
        [ValidateAntiForgeryToken]
        public ActionResult Createupdate(TblCgyoeModel tblCgyoe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsUpdated = tblCgyoeManager.createProduct(tblCgyoe);
                    if (IsUpdated)
                    {
                        TempData["Info Message"] = "--Message Center: Creation Successfull--";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Info Message"] = "--Message Center: Creation NOT Successfull--";
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

        }//Createupdate

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
        }//Edit

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit(int id, TblCgyoeModel tblCgyoeModel)
        {
            try
            {
                    if (ModelState.IsValid)
                    {
                        bool IsUpdated = tblCgyoeManager.UpdateRequest(id, tblCgyoeModel);
                        if (IsUpdated)
                        {
                            TempData["Info Message"] = "--Message Center: Edit successful--";
                            return RedirectToAction("Index", new { id = "notApproved" });
                        }
                        else
                        {
                            TempData["Info Message"] = "--Message Center: Edit was NOT successful, remove all special characters--";
                            return RedirectToAction("Edit", new { id = id });
                        }
                    }
                    else
                    {
                    TempData["Info Message"] = "--Message Center: Edit was NOT successful, remove all special characters--";
                    return RedirectToAction("Edit", new { id = id });
                    }
                return RedirectToAction("Index", new { id = "notApproved" });
            }
            catch (Exception ex)
            {

                TempData["Info Message"] = ex.Message;
                return View();
            }
        }//Edit

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
        public ActionResult Delete(int id, TblCgyoeModel tblCgyoe)
        {
            //string result = tblCgyoeManager.Delete(id);
            //return RedirectToAction("Index");
            try
            {
                string result = tblCgyoeManager.Delete(id);
                TempData["Info Message"] = "--Message Center: Delete was Success--";
                return RedirectToAction("Index", new { id = "notApproved" });
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }

        }//Delete

        // PRINT: =====================================================================
        //[ActionName("Print")]
        //public ActionResult Print(int id)
        //{
        //    string reportPath = "C:/Users/edoucett/Desktop/OperatingExpense/MorrisonOEPO.rpt";

        //    //ReportDocument reportDocument = new();
        //    //reportDocument.Load(reportPath);
        //    //reportDocument.SetParameterValue("@RequestID", id);
        //    //reportDocument.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "MorrisonOEPO");
        //    ////Stream stream = reportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
        //    ////stream.Seek(0, SeekOrigin.Begin);
        //    //reportDocument.Close();
        //    //return View(stream);

        //    //ReportDocument myDataReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //    //myDataReport.Load(reportPath);
        //    //myDataReport.SetParameterValue("@RequestId", id);
        //    //return View(myDataReport);
        //}



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
