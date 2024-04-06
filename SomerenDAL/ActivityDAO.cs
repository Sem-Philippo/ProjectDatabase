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
    public class ActivityDAO : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activityId, activityName FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Activity GetActivityById(int id)
        {
            string query = $"SELECT activityId, activityName FROM Activity WHERE activityId = {id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //not making seperate method until I only need 1 entry twice or more
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                activities.Add(CreateActivityFromDataRow(dr));
            }
            return activities;
        }
        private Activity CreateActivityFromDataRow(DataRow dr)
        {
            return new Activity()
            {
                Id = (int)dr["activityId"],
                Name = dr["activityName"].ToString(),
            };
        }
    }
}
