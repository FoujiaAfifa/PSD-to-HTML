using MyMVCApp.DatabaseContext.DatabaseContext;
using MyMVCApp.Models.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCApp.Repository.Repository
{
    public class CourseRepository
    {
        StudentDbContext db = new StudentDbContext();
        public bool Add(Course course)
        {
            int isExecuted = 0;

            db.Courses.Add(course);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Course course)
        {
            int isExecuted = 0;
            Course aCourse = db.Courses.FirstOrDefault(c => c.ID == course.ID);

            db.Courses.Remove(aCourse);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Course course)
        {
            int isExecuted = 0;
            //Method 1
            Course aCourse = db.Courses.FirstOrDefault(c => c.ID == course.ID);
            if (aCourse != null)
            {
                    aCourse.Name = course.Name;
                isExecuted = db.SaveChanges();
            }

            //Method 2
            //db.Entry(student).State = EntityState.Modified;
            //isExecuted = db.SaveChanges();
            //if (isExecuted > 0)
            //{
            //    return true;
            //}
            return false;
        }
    }
}
