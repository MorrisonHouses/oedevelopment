using Microsoft.AspNetCore.Mvc;
using OEWebApplicationApp.Models;
using System.Diagnostics;

namespace OEWebApplicationApp.Controllers
{
    public class HomeController : Controller
    {
        private IHttpContextAccessor Accessor;
        //public HomeController(IHttpContextAccessor accessor)
        //{
        //    Accessor = accessor;
        //}
        public string NewUserName()
        {
            string value;
            value = HttpContext.User.Identity.Name.Remove(0, 14).ToLower();
            //value = "CSaguez";
            //value = "edoucett";
            return value;
        }
        public IActionResult Index()
        {
            //string userName = HttpContext.User.Identity.Name;
            string userName = NewUserName();

            //userName = userName.Remove(0, 14);
            /*calls username*/
            ManagerViewGLaccount viewGLaccountManager = new ManagerViewGLaccount();
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ManagerViewGLaccount managerViewGLaccount = new();
            ViewBag.Servername = configclass.ServerUsername();
            //ViewBag.UserName = configclass.username();
            ViewBag.DateTime = function.dateTime();
            ViewBag.UserName = userName;
            ViewBag.ApproverBool = viewGLaccountManager.GetApprovalBool(userName);
            ViewBag.RequesterBool = viewGLaccountManager.GetRequestBool(userName);
            try
            {
                //ViewBag.UserName = configclass.username();
                //ViewBag.UserName = userName;
                ViewBag.ApproverBool = viewGLaccountManager.GetApprovalBool(userName);
                ViewBag.RequesterBool = viewGLaccountManager.GetRequestBool(userName);
            }
            catch (Exception ex)
            {
                TempData["Info Message"] = ex.Message;
                return View();
            }

            return View();
        }

        public IActionResult UnderConstruction()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}