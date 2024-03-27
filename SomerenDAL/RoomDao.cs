using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT roomNr, floorNr, buildingNr, numBeds FROM Room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadRooms(dataTable);
        }

        private List<Room> ReadRooms(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();
            foreach (DataRow dr in dataTable.Rows)
            {
                rooms.Add(CreateRoomFromDataRow(dr));
            }
            return rooms;
        }

        private Room CreateRoomFromDataRow(DataRow dr)
        {
            // ...
            return new Room()
            {
                Number = (int)dr["roomNr"],
                Floor = (int)dr["floorNr"],
                Building = (int)dr["buildingNr"],
                Beds = (int)dr["numBeds"]
            };
        }
    }
}
