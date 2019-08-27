using SmallBusinessManagementApp.BLL.BLL;
using SmallBusinessManagementApp.DatabaseContext.DatabaseContext;
using SmallBusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace SmallBusinessManagementApp.Controllers
{
    public class ReportController : Controller
    {

        ReportManager _reportManager = new ReportManager();


        public ActionResult Report()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Report(DateTime? startdate, DateTime? enddate)
        {

            var rangeData = _reportManager.Report(startdate, enddate);

            return View(rangeData);

        }

    }
}