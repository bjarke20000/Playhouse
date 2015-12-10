using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_play
{
    class Fibunacci
    {
        /*
         * returns 0 when i is 0 or less.
         * returns -1 if i is null.
         * 
         * The number is found by a recusive call of the method
         */
        public static int getFibonacciNrRecursive(int i)
        {
            int result;
            if (!i.Equals(null))
            {
                if (i < 0)
                {
                    result = 0;
                }
                else if (i == 1 || i == 2)
                {
                    result = 1;
                }
                else
                {
                    result = getFibonacciNrRecursive(i - 1) + getFibonacciNrRecursive(i - 2);
                }
            }
            else
            {
                result = -1;
            }

            return result;
        }

        /*
         * returns 0 when i is 0 or less.
         * returns -1 if i is null.
         * 
         * The result is found by summing togehter the numbers with a for loop.
         */
        public static int getFibonacciNrIterative(int i)
        {
            int result = 0;
            int calc = 1;

            if (!i.Equals(null))
            {
                for (int n = 0; n < i; n++)
                {
                    int temp = result;
                    result = calc;
                    calc = calc + temp;
                }
            }
            else
            {
                result = -1;
            }

            return result;
        }
    }
}
