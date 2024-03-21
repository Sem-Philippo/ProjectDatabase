using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT * FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                teachers.Add(ReadTeacher(dr));
            }
            return teachers;
        }
        private Teacher ReadTeacher(DataRow dr)
        {
            return new Teacher()
            {
                Name = dr["lecturerName"].ToString(),
                AgeInYears = ((int)dr["age"]),
                PhoneNumber = (string)dr["phoneNumber"],
            };
        }

    }
}
