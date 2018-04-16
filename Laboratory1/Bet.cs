using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
     public class Bet

    {
        public int Amount; // Ilość postawionych pieniędzy
        public int Dog; // Numer ,psa na którego postawiono
        public Guy Bettor;// Facet , który zawarł zakład
        
       
       public int PayOut(int Winner)
        {
            if (Bettor.MyBet.Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return  -Amount;
            }
            

        }
    }

}
