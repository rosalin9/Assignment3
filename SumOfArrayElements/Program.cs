using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrayElements
{
    /// <summary>
    /// program to sum of elements in an array
    /// </summary>
    public class Program
    {
        static void Array(List<int> array) 
        {
            int sum = 0;
            foreach (int i in array)
            { 
                sum += i;
            }
            Console.WriteLine("The sum of the elements of the array is " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input 5 elements in the array : ");
            List<int> firstlist = new List<int>();
            for(int i = 0; i<5;  i++) 
            {
                Console.Write($"element - {i} : ");
                firstlist.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Array(firstlist);
            
            Console.Read();
            
        }
    }
}
