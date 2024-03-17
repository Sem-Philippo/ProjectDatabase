using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;
using Microsoft.VisualBasic;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM Drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void SaveExistingDrink(Drink drink)
        {
            string query = "UPDATE Drink SET [Name] = '" + drink.Name + "', [Price] = " + (decimal)(double)drink.Price + ", [Stock] = " + drink.StockAmount + ", [Alcoholic] = '" + drink.Alcoholic + "'  WHERE DrinkId = " + drink.Id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void SaveNewDrink(Drink drink)
        {
            string query = $"SET IDENTITY_INSERT [dbo].[Drink] ON INSERT [dbo].[Drink] ([Name], [Price], [Stock], [DrinkID], [Alcoholic], [VAT]) VALUES ('{drink.Name}', {(decimal)(double)drink.Price:0.00}, {drink.StockAmount}, {drink.Id}, '{drink.Alcoholic}', {drink.VAT})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteExistingDrink(Drink drink)
        {
            string query = $"DELETE FROM Drink WHERE DrinkId = {drink.Id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Id = (int)dr["DrinkId"],
                    Name = (string)dr["Name"],
                    Alcoholic = (bool)dr["Alcoholic"],
                    Price = (float)(double)dr["Price"],
                    StockAmount = (int)dr["Stock"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
