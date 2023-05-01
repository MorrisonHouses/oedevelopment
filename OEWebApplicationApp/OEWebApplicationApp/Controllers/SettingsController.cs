using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace OEWebApplicationApp.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            /*calls username, GST, CONFIG FILE LOCATION, USER ADDRESS*/
            ClassFunctions function = new();
            ClassConfig configclass = new();
            ViewBag.Address = configclass.Address();
            ViewBag.UserName = configclass.username();
            ViewBag.GST = configclass.ConfigGST();
            ViewBag.CONFLOC = configclass.ConfigLocation();
            ViewBag.EXPLOC = configclass.ExportLocation();
            ViewBag.DateTime = function.dateTime();

            return View();
        }
    }
}
