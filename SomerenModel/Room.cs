namespace SomerenModel
{
    public class Room
    {
        public string Number { get; set; }     // Room Number, e.g. 206

        public int Size { get; set; } // number of beds, e.g. 8 or 1

        public bool Type { get; set; } // Type, could be either lecturer or student
    }
}