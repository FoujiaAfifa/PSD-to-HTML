using CrystalDecisions.CrystalReports.Engine;
using CrystalReportPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalReportPractice.Controllers
{
    public class StockReportController : Controller
    {
        StockManagementDBEntities1 _db = new StockManagementDBEntities1();

        // GET: StockReport
        public ActionResult StockList()
        {
            var stockList = _db.Stocks.ToList();

            return View(stockList);
        }

        public ActionResult exportReport()
        {
            ReportDocument rd = new ReportDocument();


        }
    }
}