using OrderWebApp.DatabaseContext.DatabaseContext;
using OrderWebApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderWebApp.Repository.Repository
{
   public class MemberRepository
    {
        OrderDbContext _db = new OrderDbContext();

        public bool Add(Member member)
        {
            bool isSaved = false;
            _db.Members.Add(member);
            int Saved = _db.SaveChanges();

            if(Saved>0)
            {
                isSaved = true;
            }

            return isSaved;
        }

        public List<SelectListItem> GetTypeSelectListItems()
        {
            var dataList = _db.MemberTypes.ToList();

            var TypeSelectListItems = new List<SelectListItem>();

            TypeSelectListItems.AddRange(GetDefaultSelectListItem());

            if (dataList != null && dataList.Count > 0)
            {
                foreach (var membertype in dataList)
                {
                    var selectListItem = new SelectListItem();
                    selectListItem.Text = membertype.TypeName;
                    selectListItem.Value = membertype.ID.ToString();

                    TypeSelectListItems.Add(selectListItem);
                }
            }
            return TypeSelectListItems;
        }

        public List<Member> GetByID(int id)
        {
            return _db.Members.Where(c => c.ID == id).ToList();
        }

        private IEnumerable<SelectListItem> GetDefaultSelectListItem()
        {
            var dataList = new List<SelectListItem>();
            var defaultSelectListItem = new SelectListItem();
            defaultSelectListItem.Text = "---Select---";
            defaultSelectListItem.Value = "";
            dataList.Add(defaultSelectListItem);
            return dataList;
        }

        public bool GetDuplicateMember(string code)
        {
            Member member = _db.Members.Where(c => c.Code == code).FirstOrDefault();
            if (member != null)
            {
                return true;
            }

            return false;

        }

        public List<Member> GetAll()
        {

            return _db.Members.ToList();
        }
    }
}
