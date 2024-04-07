using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkID { get; set; }     // drink ID, e.g. 5
        public string Name { get; set; }   // Name, e.g. Beer
        public bool Alcoholic { get; set; }      // Alcoholic, either alcholoic or non-alcoholic
        public double Price { get; set; }      // Price, e.g. 2.00 euros

        public int Stock { get; set; } // Stock, e.g. 100

        // the status of the drink's stocks based on the number recieved from the database
        public StockStatus StockStatus
        {
            get
            {
                switch (Stock)
                {
                    case 0:
                        return StockStatus.Empty;
                        

                    case <= 10:
                        return StockStatus.NearlyDepleted;

                    // the default is full since it has no real condition 
                    default:
                        return StockStatus.Full;
                }
            }
            
        }
    }
}
