using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    // an enum for the stock status because it's fancy- I mean more efficient and organised
    public enum StockStatus
    {
        // when it's empty inside... the stocks not you
        Empty,
        
        // when it doesn't have much to go on
        NearlyDepleted,

        // when the stocks are full
        Full
    }
}
