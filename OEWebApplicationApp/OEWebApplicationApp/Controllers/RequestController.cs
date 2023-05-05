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
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MORSQLCONN"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@", username);

            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();

            //return View();
            return View();
        }

        // POST: RequestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RequestController/Edit/5
        public ActionResult Edit(int id)
        {
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            var OElist = tblCgyoeManager.GetViewOERequestById(id).FirstOrDefault();
            if (OElist == null)
            {
                TempData["Info Message"] = "No item available" + id.ToString();
                return RedirectToAction("Index");
            }
            return View(OElist);
        }

        //[HttpPost]
        [ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(TblCgyoe tblCgyoe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsUpdated = tblCgyoeManager.UpdateRequest(tblCgyoe);
                    if (IsUpdated)
                    {
                        TempData["Info Message"] = "updated success";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Info Message"] = "updated was not success";
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

        // EDIT: =====================================================================
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RequestController/Delete/5
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
    }
}
