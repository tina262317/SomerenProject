namespace SomerenModel
{
    public class Room
    {
        public int Number { get; set; }     // RoomNumber, e.g. 206
        public char Building { get; set; }   // Building, e.g. A or B
        public int Floor { get; set; }      // Floor, e.g. 1, 2, 3
        public int NumberOfBeds { get; set; }      // numberOfBeds, could be either 8 or 1

        public bool Type { get; set; } // Type of room, could be either lecturer or student
    }
}