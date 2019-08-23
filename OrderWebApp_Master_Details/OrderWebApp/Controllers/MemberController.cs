using OrderWebApp.BLL.BLL;
using OrderWebApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderWebApp.Controllers
{
    public class MemberController : Controller
    {
        MemberManager _memberManager = new MemberManager();
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            Member member = new Member();
            member.TypeList = _memberManager.GetTypeSelectListItems();
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Member member)
        {
            
            try
            {
                member.TypeList = _memberManager.GetTypeSelectListItems();
                if (ModelState.IsValid)
                {

                    if(GetDuplicateMember(member.Code)== false)
                    {
                       var isSaved= _memberManager.Add(member);

                        if (isSaved)
                        {
                            ViewBag.SMsg = "Member Saved";
                        }
                        else
                        {
                            ViewBag.FMsg = "Member Not Saved";
                        }
                    }
                    else
                    {
                        ViewBag.DMsg = "Member Already Exsits";
                        return View(member);
                    }


                }

            }

            catch(Exception ex)
            {
                ViewBag.ExMsg = ex.Message;

            }

            return View(member);
        }

        private bool GetDuplicateMember(string code)
        {
            return _memberManager.GetDuplicateMember(code);
        }
    }
}