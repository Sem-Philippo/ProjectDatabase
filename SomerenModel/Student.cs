using System;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; } // database id
        public string Name { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public string PhoneNumber { get; set; } //Student's phone number
        public string Class { get; set; } //which class the student is in
        public int RoomNumber { get; set; } //which room the student sleeps in
        public DateTime BirthDate { get; set; }
    }
}