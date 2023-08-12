using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTypeOfTriangle
{
    /// <summary>
    /// program  to check whether a triangle is Equilateral, Isosceles or Scalene
    /// </summary>
    public class Program
    {
        static string TypeOfTriangle(int x, int y, int z)
        {
            if (x == y && y == z)
                return "This is an Equilateral triangle";
            else if (x == y || x == z || y == z)
                return "This is an Isosceles triangle";
            else
                return "This is a Scalene triangle";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three sides of a triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TypeOfTriangle(side1, side2, side3));

            Console.Read();

        }
    }
}
