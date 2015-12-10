using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_play
{
    class BipBop
    {
        /*
         * bipbop is a "game" where if the number inputed are divisable by 3 it prints Bip
         * and if it is divisable by 5 it prints Bop and if it is divisable by both 3 and 5
         * it prints BipBop. If it isn't divisable by either 3 or 5 it prints Failure, same
         * goes if the number is zero.
         */
        public static string playGame(int i)
        {
            string result = "";
            if(!i.Equals(null)){
                if (i == 0) result = "Failure";
                else if (i % 3 == 0 && i % 5 == 0) result = "BipBop";
                else if(i % 3 == 0) result = "Bip";
                else if(i % 5 == 0) result = "Bop";
                else result = "Failure";
            }
            else result = "unable to play";

            return result;
        }
    }
}
