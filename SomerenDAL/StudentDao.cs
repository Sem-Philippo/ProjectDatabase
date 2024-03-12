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
            string query = "SELECT * FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentNr"],
                    Name = dr["studentName"].ToString(),
                    PhoneNumber = dr["studentPhoneNr"].ToString(),
                    Class = dr["class"].ToString(),
                    RoomNumber = (int)dr["roomNr"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}