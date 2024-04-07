using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentNr, studentName, studentPhoneNr, class, roomNr FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<string> GetAllClasses()
        {
            string query = "SELECT DISTINCT class FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            List<string> classes = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                classes.Add((string)row["class"]);
            }

            return classes;
        }

        public void InsertStudent(Student student)
        {
            string query = "INSERT INTO Student (studentName, studentPhoneNr, class, roomNr) VALUES (@Name, @PhoneNumber, @Class, @RoomNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", student.Name);
            sqlParameters[1] = new SqlParameter("@PhoneNumber", student.PhoneNumber);
            sqlParameters[2] = new SqlParameter("@Class", student.Class);
            sqlParameters[3] = new SqlParameter("@RoomNumber", student.RoomNumber);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteStudent(Student student)
        {
            string query = "DELETE FROM Student WHERE studentName = @Name AND studentPhoneNr = @PhoneNumber AND class = @Class AND roomNr = @RoomNumber";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", student.Name);
            sqlParameters[1] = new SqlParameter("@PhoneNumber", student.PhoneNumber);
            sqlParameters[2] = new SqlParameter("@Class", student.Class);
            sqlParameters[3] = new SqlParameter("@RoomNumber", student.RoomNumber);
            int rowsAffected = ExecuteDeleteQuery(query, sqlParameters);

            if (rowsAffected == 0)
            {
                throw new Exception("No such student exists, please check the data you entered");
            }
        }

        public bool StudentHasOrders(int studentNr)
        {
            string query = "SELECT COUNT(*) FROM Orders WHERE studentNr = @StudentNr";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@StudentNr", studentNr);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            int orderCount = (int)dataTable.Rows[0][0];
            return orderCount > 0;
        }



        public int GetStudentNrByStudentName(string studentName)
        {
            string query = "SELECT StudentNr FROM Student WHERE studentName = @Name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Name", studentName);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                return (int)dataTable.Rows[0]["StudentNr"];
            }
            else
            {
               return -1;
            }
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                students.Add(CreateStudentFromDataRow(dr));
            }
            return students;
        }
        private Student CreateStudentFromDataRow(DataRow dr)
        {
            return new Student()
            {
                Number = (int)dr["StudentNr"],
                Name = dr["studentName"].ToString(),
                PhoneNumber = dr["studentPhoneNr"].ToString(),
                Class = dr["class"].ToString(),
                RoomNumber = (int)dr["roomNr"]
            };
        }
    }
}