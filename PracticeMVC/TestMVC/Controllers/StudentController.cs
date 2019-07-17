using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.BLL.BLL;
using TestMVC.Models.Models;

namespace TestMVC.Controllers
{
    public class StudentController : Controller
    {

        StudentManager _studentManager = new StudentManager();
        Student _student = new Student();
        public ActionResult Add()
        {
            _student.Name = "Lubna";
            _studentManager.Add(_student);

            return View();
        }
        public ActionResult Delete()
        {
            _student.ID = 1;
      
            _studentManager.Delete(_student);

            return View();
        }

        public ActionResult Update()
        {
            _student.ID = 3;
            _student.Name = "Tarun";

            _studentManager.Update(_student);

            return View();
        }
        public ActionResult GetByID()
        {
            _student.ID = 3;
            Student bstudent = _studentManager.GetByID(_student);


            return View();
        }
        public ActionResult GetAll()
        {
            _student.ID = 3;
            List<Student> bStudent = _studentManager.GetAll(_student);

            return View();
        }
    }
}