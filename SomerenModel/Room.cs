namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; }         // database id
        public int Number { get; set; }     // RoomNumber, e.g. 206
        public int Floor { get; set; }
        public int Building { get; set; }
        public int Beds { get; set; }
    }
}