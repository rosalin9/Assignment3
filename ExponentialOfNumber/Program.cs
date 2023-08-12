using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentialOfNumber
{
    /// <summary>
    /// program to create a function to calculate the result of raising an integer number to another.
    /// </summary>
    public class Program
    {
        static void Exponent(int a, int b)
        {
            Console.WriteLine($"So, the number {a} ^ (to the power) {b} = " + Math.Pow(a,b));
        }
        static void Main(string[] args)
        {
            Console.Write("Input Base number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Exponent: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Exponent(x, n);

            Console.Read();
        }
    }
}
