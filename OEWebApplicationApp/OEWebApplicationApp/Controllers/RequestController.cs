using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OEWebApplicationApp.Models;

namespace OEWebApplicationApp.Controllers
{
    public class RequestController : Controller
    {
        //instace of helper classes======================================================
        ClassFunctions function = new();
        ClassConfig configclass = new();


        /// <summary>
        /// pulls from the vmort swl express table and filters list by name of user
        /// </summary>
        /// <returns>list</returns>
        public IActionResult GetRequest()
        {
            ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.RequesterBool = ViewGLaccountManager.GetRequestBool();

            ClassConfig classConfig = new ClassConfig();
            List<ViewGlaccount> viewGlaccounts = ViewGLaccountManager.GetViewGlaccounts();

            List<ViewGlaccountModel> listing = (
                from ViewGlaccount in viewGlaccounts where ViewGlaccount.GateKeeper == classConfig.username()
                select new ViewGlaccountModel
                {
                    Account = ViewGlaccount.Account,
                    AccountTitle = ViewGlaccount.AccountTitle,
                    GateKeeper = ViewGlaccount.GateKeeper,
                    ApprovalThreshold = ViewGlaccount.ApprovalThreshold,
                    ApprovalGateKeeper = ViewGlaccount.ApprovalGateKeeper,
                }
                ).ToList();
            return View(listing);
        }


        // GET: RequestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RequestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RequestController/Create
        public ActionResult Create()
        {
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
            return View();
        }

        // POST: RequestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RequestController/Delete/5
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
