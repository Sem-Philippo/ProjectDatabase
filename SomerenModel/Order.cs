using System;

namespace SomerenModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int DrinkID { get; set; }
        public int orderAmount { get; set; }
        public int studentNr { get; set; }
        public DateTime OrderTime { get; set; }
    }
}