using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    /// <summary>
    /// program to create recursive function to calculate factorial of a number
    /// </summary>
    public class Program
    {
        public static int Fact(int x)
        {
            if (x >= 1)
                return x * Fact(x - 1);
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The factorial of {n}! is " + Fact(n));
            Console.Read();

        }
    }
}
