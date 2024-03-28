using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class SupervisorDAO : BaseDao
    {
        public List<Teacher> GetSupervisorsByActivity(Activity activity)
        {
            string query = $"SELECT lecturerId FROM Supervisors WHERE activityId = {activity.Id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetNonSupervisorsByActivity(Activity activity)
        {
            string query = $"SELECT lecturerId FROM Lecturer WHERE lecturerId NOT IN (SELECT LecturerId FROM Supervisors WHERE ActivityId = {activity.Id})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void RemoveSupervisor(int supervisorId, Activity activity)
        {
            string query = $"DELETE FROM Supervisors WHERE ActivityId = {activity.Id} AND LecturerId = {supervisorId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddSupervisor(int supervisorId, Activity activity)
        {
            string query = $"INSERT [dbo].[Supervisors] ([LecturerId],[ActivityId]) VALUES ({supervisorId}, {activity.Id})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();
            TeacherDao teacherDao = new TeacherDao();

            foreach (DataRow dr in dataTable.Rows)
            {
                //get each supervisor's id and get the teacher linked to it
                supervisors.Add(teacherDao.GetTeacherById((int)dr["LecturerId"]));
            }
            return supervisors;
        }
    }
}
