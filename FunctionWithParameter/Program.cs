using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionWithParameter
{
    /// <summary>
    /// program to create a user defined function with parameter
    /// </summary>
    public class Program
    {
        static void Function(string str)
        {
            Console.WriteLine($"Welcome friend {str} !");
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {
            Console.Write("Please input a name : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Function(name);

            Console.Read();
        }
    }
}
