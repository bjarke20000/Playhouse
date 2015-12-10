using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_play
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Todo interaction: choise between parts.
             * Todo move tests to a seperate class!
             * 
             * manual test
             */
            int fib = -5;
            Console.WriteLine("Fibunacci");
            Console.WriteLine("recursive: " + Fibunacci.getFibonacciNrRecursive(fib));
            Console.WriteLine("iterative: " + Fibunacci.getFibonacciNrIterative(fib));
            Console.WriteLine("");



            Console.WriteLine("BipBop");
            Console.WriteLine("BipBop 15: " + BipBop.playGame(15));
            Console.WriteLine("BipBop 5: " + BipBop.playGame(5));
            Console.WriteLine("BipBop 3: " + BipBop.playGame(3));
            Console.WriteLine("BipBop 2: " + BipBop.playGame(2));
            Console.WriteLine("BipBop 0: " + BipBop.playGame(0));

            Console.ReadLine();
        }





    }
}
