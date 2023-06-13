using Microsoft.AspNetCore.Mvc;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports;
using Microsoft.Reporting.WebForms;

namespace OEWebApplicationApp.Controllers
{
    public class ReportController : Controller
    {

        public IActionResult Index(string RequestId)
        {
            
            ReportDocument reportDocument = new ();

            reportDocument.Load(@"~\Report\MorrisonOEPO.rpt");
            
            reportDocument.SetParameterValue("@RequestId", RequestId);
            reportDocument.SetParameterValue("@VendorName", "Test");
            reportDocument.SetParameterValue("@Tax", 0);

            //var exportOptions = reportDocument.ExportOptions;
            //exportOptions.ExportDestinationType = ExportDestinationType.NoDestination;
            //exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            //var req = new ExportRequestContext { ExportInfo = exportOptions };
            //var stream = reportDocument.FormatEngine.ExportToStream(req);

            return View(reportDocument);

        }


    }//class
}//namespace
