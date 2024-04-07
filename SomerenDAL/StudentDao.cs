using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT [student number],[room number], [first name], [last name], [telephone], [class] FROM student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // method to read from the table and make a list of all students
        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                // use seperate method for creating a new student from each row
                Student student = CreateStudentFromDataRow(dr);

                students.Add(student);
            }
            return students;
        }

        // method creates a new student from each row 
        private Student CreateStudentFromDataRow(DataRow dr)
        {
            return new Student()
            {
                StudentNumber = (int)dr["student number"],
                RoomNumber = (string)dr["room number"],
                FirstName = (string)dr["first name"],
                LastName = (string)dr["last name"],
                Telephone = (int)dr["telephone"],
                Class = (string)dr["class"]
            };
        }


        // method for adding a new student
        public void AddStudent(Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@student_number", student.StudentNumber),
                new SqlParameter("@room_number", student.RoomNumber),
                new SqlParameter("@first_name", student.FirstName),
                new SqlParameter("@last_name", student.LastName),
                new SqlParameter("@telephone", student.Telephone),
                new SqlParameter("@class", student.Class),
            };
            // insert into the table while passing the parameters to it
            ExecuteEditQuery("INSERT INTO [student] VALUES (@student_number, @room_number, @first_name, @last_name, @telephone, @class);", sqlParameters);
        }

        //  method to change an existing student
        public void ChangeStudent(Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@student_number", student.StudentNumber),
                new SqlParameter("@room_number", student.RoomNumber),
                new SqlParameter("@first_name", student.FirstName),
                new SqlParameter("@last_name", student.LastName),
                new SqlParameter("@telephone", student.Telephone),
                new SqlParameter("@class", student.Class),
            };
            // update the table while passing the parameters to it
            ExecuteEditQuery("UPDATE [student] SET [student number]=@student_number, [room number]=@room_number, [first name]=@first_name, [last name]=@last_name, [telephone]=@telephone, [class]=@class WHERE [student number] = @student_number;", sqlParameters);
        }

        // method to delete an existing student
        public void DeleteStudent(Student student)
        {
            // since we can delete only based on drink ID no need for other parameters
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@student_number", student.StudentNumber)
            };
            // delete from the table with condition of matching the drink ID
            ExecuteEditQuery("DELETE FROM [student] WHERE [student number] = @student_number", sqlParameters);
        }
    }
}