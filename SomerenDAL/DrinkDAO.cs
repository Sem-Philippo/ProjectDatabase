﻿using System.Collections.Generic;
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
            string query = "SELECT DrinkId, Name, Alcoholic, " +
                "Price, Stock FROM Drink ORDER BY Name ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //Don't forget to include sales amount once drink orders are implemented!
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void SaveExistingDrink(Drink drink)
        {
            string query = "UPDATE Drink SET [Name] = '" + drink.Name + "'," +
                " [Price] = " + (decimal)(double)drink.Price + "," +
                " [Stock] = " + drink.StockAmount + ", [Alcoholic] = '" + 
                drink.Alcoholic + "'  WHERE DrinkId = " + drink.Id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void SaveNewDrink(Drink drink)
        {
            string query = $"INSERT [dbo].[Drink] ([Name]," +
                $" [Price], [Stock], [Alcoholic], [VAT]) " +
                $"VALUES ('{drink.Name}', {(decimal)(double)drink.Price:0.00}," +
                $" {drink.StockAmount}, '{drink.Alcoholic}', {drink.VAT})";
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
                drinks.Add(CreateDrinkFromDataRow(dr));
            }
            return drinks;
        }
        private Drink CreateDrinkFromDataRow(DataRow dr)
        {
            return new Drink()
            {
                Id = (int)dr["DrinkId"],
                Name = (string)dr["Name"],
                Alcoholic = (bool)dr["Alcoholic"],
                Price = (float)(double)dr["Price"],
                StockAmount = (int)dr["Stock"],
            };
        }
    }
}
