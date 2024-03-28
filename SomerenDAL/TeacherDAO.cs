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
            string query = "SELECT LecturerName, age, phoneNumber, lecturerId FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Teacher GetTeacherById(int id)
        {
            string query = $"SELECT LecturerName, age, phoneNumber, LecturerId FROM Lecturer WHERE LecturerId = {id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //ReadTables returns a list, but I only need 1 entry.
            //Until there are 2 or more methods that need a singular entry, I won't 
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                teachers.Add(CreateTeacherFromDataRow(dr));
            }
            return teachers;
        }
        private Teacher CreateTeacherFromDataRow(DataRow dr)
        {
            return new Teacher()
            {
                Name = dr["lecturerName"].ToString(),
                AgeInYears = ((int)dr["age"]),
                PhoneNumber = (string)dr["phoneNumber"],
                Id = (int)dr["lecturerId"],
            };
        }

    }
}
