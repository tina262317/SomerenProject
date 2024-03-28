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

        public List<Room> GetRooms()
        {
            List<Room> rooms = accomodationdb.GetAllRooms();
            return rooms;
        }
    }
}