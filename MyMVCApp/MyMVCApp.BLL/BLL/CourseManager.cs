using MyMVCApp.Models.Models;
using MyMVCApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCApp.BLL.BLL
{
   public class CourseManager
    {
        CourseRepository _courseRepository = new CourseRepository();
        public bool Add(Course course)
        {
            return _courseRepository.Add(course);
        }
        public bool Delete(Course course)
        {
            return _courseRepository.Delete(course);
        }
        public bool Update(Course course)
        {
            return _courseRepository.Update(course);
        }
    }
}
