using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;
using Microsoft.VisualBasic;
using System.Collections;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {

        public List<Order> GetAllOrders()
        {
            try
            {
                string query = "SELECT studentNr, DrinkID, orderAmount, orderTime FROM [dbo].[Orders]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }



        public void InsertOrder(int studentNr, int drinkID, int orderAmount, DateTime orderTime)
        {
            try
            {
                string query = "INSERT INTO [dbo].[Orders] ([studentNr], [DrinkID], [orderAmount], [orderTime]) VALUES (@studentNr, @DrinkID, @orderAmount, @orderTime)";
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@studentNr", SqlDbType.Int) { Value = studentNr };
                sqlParameters[1] = new SqlParameter("@DrinkID", SqlDbType.Int) { Value = drinkID };
                sqlParameters[2] = new SqlParameter("@orderAmount", SqlDbType.Int) { Value = orderAmount };
                sqlParameters[3] = new SqlParameter("@orderTime", SqlDbType.DateTime) { Value = orderTime };
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }




        public Drink GetDrinkByName(string drinkName)
        {
            try
            {
                string query = $"SELECT * FROM Drink WHERE Name = @drinkName";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@drinkName", SqlDbType.NVarChar);
                sqlParameters[0].Value = drinkName;

                DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow dr = dataTable.Rows[0];
                    return new Drink()
                    {
                        DrinkID = (int)dr["DrinkID"],
                        Name = (string)dr["Name"]
                        // Add other properties as needed
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }


        public List<Order> GetOrdersByStudent(int studentNr)
        {
            try
            {
                string query = $"SELECT studentNr, DrinkID, orderAmount FROM Orders WHERE studentNr = {studentNr}";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (SqlException e)
            {
                throw new Exception("SQL Error: " + e.ErrorCode);
            }
        }
        public Student GetStudentByName(string studentName)
        {
            try
            {
                string query = $"SELECT * FROM Student WHERE studentName = @studentName";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@studentName", SqlDbType.NVarChar);
                sqlParameters[0].Value = studentName;

                DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow dr = dataTable.Rows[0];
                    return new Student()
                    {
                        studentNr = (int)dr["studentNr"],
                        studentName = (string)dr["studentName"]
                    };
                }
                else
                {
                    return null;
                }
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
                    // OrderId = (int)dr["orderId"],
                    studentNr = (int)dr["studentNr"],
                    DrinkID = (int)dr["DrinkID"],
                    orderAmount = (int)dr["orderAmount"],
                    OrderTime = (DateTime)dr["orderTime"]
                };

                orders.Add(order);
            }

            return orders;
        }

    }
}
