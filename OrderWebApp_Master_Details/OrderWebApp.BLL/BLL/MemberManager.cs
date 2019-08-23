using OrderWebApp.Models.Models;
using OrderWebApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderWebApp.BLL.BLL
{
    public class MemberManager
    {
        MemberRepository _memberRepository = new MemberRepository();

        public bool Add(Member memeber)
        {
            return _memberRepository.Add(memeber);
        }

        public bool GetDuplicateMember(string code)
        {
            return _memberRepository.GetDuplicateMember(code);
        }

        public List<SelectListItem> GetTypeSelectListItems()
        {
            return _memberRepository.GetTypeSelectListItems();
        }

        public List<Member> GetAll()
        {
            return _memberRepository.GetAll();
        }

        public List<Member> GetByID(int id)
        {
            return _memberRepository.GetByID(id);
        }
    }
}
