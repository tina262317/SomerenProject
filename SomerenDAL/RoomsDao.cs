using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class RoomsDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT [room number], [number of beds], [type] FROM rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // method to read from the table and put all rooms in a list
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();
            // use seperate method to read a single room
            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = CreateRoomFromDataRow(dr);
                // add the newly read room to the list
                rooms.Add(room);
            }
            return rooms;
        }

        // method to create a single room
        private Room CreateRoomFromDataRow(DataRow dr)
        {
            return new Room()
            {
                Number = (string)dr["room number"],
                NumberOfBeds = (int)dr["number of beds"],
                Type = (bool)dr["type"],
            };
        }
    }

}
