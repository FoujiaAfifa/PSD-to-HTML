using SmallBusinessManagementApp.DatabaseContext.DatabaseContext;
using SmallBusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementApp.Repository.Repository
{
   public class ReportRepository
    {
        SmallBusinessDbContext db = new SmallBusinessDbContext();

        public List <Report> Report(DateTime? startdate, DateTime? enddate)
        {
           


            var rangeData =( from p in db.Purchases
                            join od in db.PurchasesDetailses on p.Id equals od.PurchaseId
                            join pro in db.Products on od.ProductId equals pro.Id

                            where p.Date >= startdate && p.Date <= enddate
                            group od by new { pro.Code, pro.Name, pro.CategoryName } into h
                            select new Report
                            {

                                Code = h.Key.Code,
                                Name = h.Key.Name,
                                Category = h.Key.CategoryName,
                                CP = h.Sum(x => x.TotalPrice),
                                MRP = h.Sum(x => x.NewMRP),
                                Profit = h.Sum(x => x.TotalPrice) - h.Sum(x => x.NewMRP)
                            }).ToList();



            //var rangeData = (db.Purchases.Join(db.PurchasesDetailses, p => p.Id, od => od.PurchaseId, (p, od) => new
            //{
            //    od.Code,
            //    CP = od.TotalPrice,
            //    MRP = od.NewMRP,
            //    Profit = (od.TotalPrice - od.NewMRP),
            //    p.Date
            //})
            //.Where(p => p.Date >= startdate && p.Date <= enddate)).ToList();

            return (rangeData);
        }


    }
}
