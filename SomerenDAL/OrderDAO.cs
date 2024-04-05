using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public void InsertOrder(int studentId, int drinkId)
        {
            try
            {
                string query = $"INSERT INTO Orders (studentId, drinkId) VALUES ({studentId}, {drinkId})";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }

        public List<Order> GetOrdersByStudent(int studentId)
        {
            try
            {
                string query = $"SELECT orderId, studentId, drinkId FROM Orders WHERE studentId = {studentId}";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["orderId"],
                    StudentId = (int)dr["studentId"],
                    DrinkId = (int)dr["drinkId"]
                };

                orders.Add(order);
            }

            return orders;
        }
    }
}
