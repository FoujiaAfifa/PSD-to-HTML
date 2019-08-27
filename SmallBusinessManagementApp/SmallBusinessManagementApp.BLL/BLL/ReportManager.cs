using SmallBusinessManagementApp.Models.Models;
using SmallBusinessManagementApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementApp.BLL.BLL
{
   public class ReportManager
    {
        ReportRepository _reportRepository = new ReportRepository();
        public List<Report> Report(DateTime? startdate, DateTime? enddate)
        {
            var rangeData = _reportRepository.Report(startdate, enddate);
            return rangeData;
        }
    }
}
