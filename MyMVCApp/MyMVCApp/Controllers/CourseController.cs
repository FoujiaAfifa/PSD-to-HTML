using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        CourseManager _courseManager = new CourseManager();
        private Course _course = new Course();

        // GET: Student
        public string Add(Course course)
        {
            //_student.ID = 101;
            _course.Name = course.Name;
            _course.Code = course.Code;
            _courseManager.Add(_course);
            return "Added";
        }
        public ActionResult Delete(Course course)
        {
            _course.ID = course.ID;
            _courseManager.Delete(_course);
            return View();
        }
        public ActionResult Update(Course course)
        {
            _course.ID = course.ID;
            //Method 1

            _course.Name = course.Name;
            _course.Code = course.Code;
            _courseManager.Update(_course);

            //Student aStudent = _studentManager.GetByID(_student);
            //if (aStudent != null)
            //{
            //    aStudent.Name = name;
            //    _studentManager.Update(aStudent);

            //}

            return View();
        }
    }
}