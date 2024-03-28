namespace SomerenModel
{
    public class Room
    {
        public int Number { get; set; }     // RoomNumber, e.g. 206
        public char Building { get; set; }   // Building, e.g. A or B
        public int floor { get; set; }      // Floor, e.g. 1, 2, 3
        public int numberOfBeds { get; set; }      // numberOfBeds, e.g. 10

        public bool type { get; set; } 
    }
}