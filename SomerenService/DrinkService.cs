using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        // Create a new library based on the database
        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        // Get all the drinks information from the drinks table in the database
        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }

        // create drinks in the database's drink table
        public void CreateDrink(Drink drink)
        {
            drinkdb.CreateDrink(drink);
        }

        // edit drinks in the database's drink table
        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }

        // delete drinks in the database's drink table
        public void DeleteDrink(Drink drink)
        {
            drinkdb.DeleteDrink(drink);
        }


    }
}
