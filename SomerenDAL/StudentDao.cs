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
            string query = "SELECT StudentNr, studentName, studentPhoneNr, class, roomNr, attendedActivity FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Student GetStudentById(int id)
        {
            string query = $"SELECT StudentNr, studentName, studentPhoneNr, class, roomNr, attendedActivity FROM Student WHERE StudentNr = {id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Student> students = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            if (students.Count > 0)
            {
                return students[0];
            }
            return null;
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
                RoomNumber = (int)dr["roomNr"],
                AttendedActivity = dr["attendedActivity"].ToString().Trim()
            };
        }
    }
}
