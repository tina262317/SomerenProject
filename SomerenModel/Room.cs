namespace SomerenModel
{
    public class Room
    {
        public string Number { get; set; }     // RoomNumber, e.g. 206

        public int NumberOfBeds { get; set; }      // numberOfBeds, could be either 8 or 1

        public bool Type { get; set; } // Type of room, could be either lecturer or student
    }
}