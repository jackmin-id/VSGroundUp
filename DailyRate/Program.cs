using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            Console.Write("Please enter a positive integer: ");
            string s = Console.ReadLine();
            long factorialValue = CalculateFactor(s);
            Console.WriteLine($"Factorial is {factorialValue}");
        }

        private long CalculateFactor(string s)
        {
            int inputValue = int.Parse(s);

            return factorial(inputValue);
        }

        private int factorial(int v)
        {
            if (v == 1)
            {
                return 1;
            }
            else
            {
                return v * factorial(v - 1);
            }
        }
    }
}
