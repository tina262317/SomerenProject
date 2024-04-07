using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }
        

        // add new students in the database's student table
        public void AddStudent(Student student)
        {
            studentdb.AddStudent(student);
        }

        // change students in the database's student table
        public void ChangeStudent(Student student)
        {
            studentdb.ChangeStudent(student);
        }

        // delete students in the database's student table
        public void DeleteStudent(Student student)
        {
            studentdb.DeleteStudent(student);
        }
    }
}