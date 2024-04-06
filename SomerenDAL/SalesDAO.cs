// SomerenDAL/SalesDao.cs

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class SalesDao : BaseDao
    {
        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT * FROM Orders WHERE OrderDate BETWEEN @StartDate AND @EndDate";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startDate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = endDate }
            };
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                orders.Add(ReadOrder(dr));
            }
            return orders;
        }

        private Order ReadOrder(DataRow dr)
        {
            DateTime orderDate = (DateTime)dr["OrderDate"];
            int totalSales = (int)dr["TotalSales"];
            decimal turnover = (decimal)dr["Turnover"];
            int numberOfCustomers = (int)dr["NumberOfCustomers"];

            Order order = new Order(orderDate, totalSales, turnover, numberOfCustomers);

            return order;
        }

    }
}
