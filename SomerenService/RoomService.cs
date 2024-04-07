using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomsDao accomodationdb;

        public RoomService()
        {
            accomodationdb = new RoomsDao();
        }

        // make a list of all rooms 
        public List<Room> GetRooms()
        {
            List<Room> rooms = accomodationdb.GetAllRooms();
            return rooms;
        }
    }
}