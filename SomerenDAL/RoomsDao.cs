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
            string query = "SELECT [room number], [number of beds], type FROM rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        } 

        

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = CreateRoomFromDataRow(dr);
                rooms.Add(room);
            }
            return rooms;
        }

        private Room CreateRoomFromDataRow(DataRow dr)
        {
            return new Room()
            {
                Number = (string)dr["room number"],
                Size = (int)dr["number of beds"],
                Type = (bool)dr["type"],
            };
        }
    }

}
