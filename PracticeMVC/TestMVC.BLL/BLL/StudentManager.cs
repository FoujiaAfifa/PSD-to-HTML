using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Models.Models;
using TestMVC.Repository.Repository;

namespace TestMVC.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }
        public bool Delete(Student student)
        {
            return _studentRepository.Delete(student);
        }
        public bool Update(Student student)
        {
            return _studentRepository.Update(student);
        }
        public List<Student> GetAll(Student student)
        {
            return _studentRepository.GetAll(student);
        }
        public Student GetByID(Student student)
        {
            return _studentRepository.GetByID(student);
        }
    }
}
