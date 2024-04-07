using SomerenModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class ParticipantDAO : BaseDao
    {
        public List<Student> GetParticipantsByActivity(Activity activity)
        {
            string query = $"SELECT studentNr FROM Participant WHERE activityID = {activity.Id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadParticipants(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Student> GetNonParticipantsByActivity(Activity activity)
        {
            string query = $"SELECT studentNr FROM Student WHERE studentNr NOT IN (SELECT studentNr FROM Participant WHERE activityID = {activity.Id})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadNonParticipants(ExecuteSelectQuery(query, sqlParameters));
        }

        public void RemoveParticipant(int studentNr, Activity activity)
        {
            string query = $"DELETE FROM Participant WHERE activityID = {activity.Id} AND studentNr = {studentNr}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddParticipant(int studentNr, Activity activity)
        {
            string query = $"INSERT INTO Participant (studentNr, activityID) VALUES ({studentNr}, {activity.Id})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Student> ReadParticipants(DataTable dataTable)
        {
            List<Student> participants = new List<Student>();
            StudentDao studentDao = new StudentDao();

            foreach (DataRow dr in dataTable.Rows)
            {
                participants.Add(studentDao.GetStudentById((int)dr["studentNr"]));
            }
            return participants;
        }

        private List<Student> ReadNonParticipants(DataTable dataTable)
        {
            List<Student> nonParticipants = new List<Student>();
            StudentDao studentDao = new StudentDao();

            foreach (DataRow dr in dataTable.Rows)
            {
                nonParticipants.Add(studentDao.GetStudentById((int)dr["studentNr"]));
            }
            return nonParticipants;
        }
    }
}
