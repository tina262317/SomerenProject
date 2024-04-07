﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {

        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT [drinkID], [name], [alcoholic], [price], [stock] FROM drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // method for reading from the table
        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            // use the method for creating each drink
            CreateDrinkFromTable(dataTable, drinks);

            return drinks;
        }

        // method for creating each drink
        private void CreateDrinkFromTable (DataTable dataTable, List<Drink> drinks)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkID = (int)dr["drinkID"],
                    Name = (string)dr["name"],
                    Alcoholic = (bool)dr["alcoholic"],
                    Price = (decimal)dr["price"],
                    Stock = (int)dr["stock"],

                };
                drinks.Add(drink);
            }
        }

        // method to create drink
        public void CreateDrink(Drink drink)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", drink.Name),
                new SqlParameter("@alcoholic", drink.Alcoholic),
                new SqlParameter("@price", drink.Price),
                new SqlParameter("@stock", drink.Stock)
            };
            // insert into the table while passing the parameters to it
            ExecuteEditQuery("INSERT INTO [drink] VALUES (@name, @alcoholic, @price, @stock); SELECT CAST(scope_identity() AS int)", sqlParameters);
        }

        //  method to update drink
        public void UpdateDrink(Drink drink)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", drink.Name),
                new SqlParameter("@Alcoholic", drink.Alcoholic),
                new SqlParameter("@price", drink.Price),
                new SqlParameter("@stock", drink.Stock)
            };
            // update the table while passing the parameters to it
            ExecuteEditQuery("UPDATE [drink] SET (@name, @alcoholic, @price, @stock) WHERE [drinkID] = [@drinkID];", sqlParameters);
        }

        // method to delete drink
        public void DeleteDrink(Drink drink)
        {
            // since we can delete only based on drink ID no need for other parameters
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@drinkID", drink.DrinkID)
            };
            // delete from the table with condition of matching the drink ID
            ExecuteEditQuery("DELETE FROM [drink] WHERE [drinkID] = [@drinkID]", sqlParameters);
        }
    }
}

