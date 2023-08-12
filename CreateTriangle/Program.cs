using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTriangle
{
    /// <summary>
    /// program to check whether the triangle is valid or not by given the angle values
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the three angles of a triangle: ");
            string s = Console.ReadLine();
            string[] num = s.Split(' ');
            int x = Convert.ToInt32(num[0]);
            int y = Convert.ToInt32(num[1]);    
            int z = Convert.ToInt32(num[2]);   
            
            if ((x+y+z) == 180)
                Console.WriteLine("The triangle is valid");
            else
                Console.WriteLine("The triangle is not valid");


            Console.Read();
        }
    }
}
