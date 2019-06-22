using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{

        //    ReportViewer reportViewer = new ReportViewer();
        //    ViewBag.ReportBook = reportViewer;
        //    return View();
        //}
        public ActionResult Index()
        {
            return View();
        }

        public FileResult File()
        {
            ReportViewer rv = new Microsoft.Reporting.WebForms.ReportViewer();
            rv.ProcessingMode = ProcessingMode.Local;
            rv.LocalReport.ReportPath = Server.MapPath("~/Reports/RDLC/Report1.rdlc");
            rv.LocalReport.Refresh();

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string[] streamids = null;
            Warning[] warnings = null;

            streamBytes = rv.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return File(streamBytes, mimeType, "Report1.pdf");
        }

        public ActionResult ReportBook()
        {
            return View();
        }

        public ActionResult ASPXUserControl()
        {
            return View();
        }
    }
}
