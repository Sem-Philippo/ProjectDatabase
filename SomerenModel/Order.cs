using System;

namespace SomerenModel
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public int TotalSales { get; set; }
        public decimal Turnover { get; set; }
        public int NumberOfCustomers { get; set; }

        // Constructor
        public Order(DateTime orderDate, int totalSales, decimal turnover, int numberOfCustomers)
        {
            OrderDate = orderDate;
            TotalSales = totalSales;
            Turnover = turnover;
            NumberOfCustomers = numberOfCustomers;
        }
    }
}
