using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    /// <summary>
    /// program to create recursive function to calculate Fibonacci series
    /// </summary>
    public class Program
    {
        public static int Fibo(int x)
        {
            if (x <= 1)
                return x;
            else
                return Fibo(x - 1) + Fibo(x-2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Fibonacci of {n} th term is " + Fibo(n));

            Console.Read();
        }
    }
}
