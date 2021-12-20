using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finacctax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AccountingServices()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult AccountPayableOutsourcing()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult AccountReceivableOutsourcing()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult FinancialAnalysisServices()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}