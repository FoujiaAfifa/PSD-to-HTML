using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVC.DatabaseContext.DatabaseContext;
using TestMVC.Models.Models;

namespace TestMVC.Repository.Repository
{
    public class StudentRepository
    {
        StudentDbContext studentDbContext = new StudentDbContext();
       public bool Add(Student student)
        {
            studentDbContext.Students.Add(student);
            int check= studentDbContext.SaveChanges();
            if(check>0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(Student student)
        {
            Student astudent = studentDbContext.Students.FirstOrDefault(c => c.ID == student.ID );

            studentDbContext.Students.Remove(astudent);
            int check = studentDbContext.SaveChanges();
            if (check > 0)
            {
                return true;
            }
            return false;
        }
        public bool Update(Student student)
        {
            Student astudent = studentDbContext.Students.FirstOrDefault(c => c.ID == student.ID);
            if(astudent!=null)
            astudent.Name = student.Name;
            studentDbContext.SaveChanges();
            return true;
        }
        public Student GetByID(Student student)
        {
            Student astudent = studentDbContext.Students.FirstOrDefault(c => c.ID == student.ID);
            return astudent;
        }
        public List<Student> GetAll(Student student)
        {
            return studentDbContext.Students.ToList();
        }

    }
}
