using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYCoordinateSystem
{
    /// <summary>
    /// program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
    /// </summary>
    public class Program
    {
        static void QuadrantOfCoordinate(int x, int y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point {(x, y)} lies in the First quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point {(x, y)} lies in the Second quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point {(x, y)} lies in the Third quadrant");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point {(x, y)} lies in the Fourth quadrant");
        }
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            int b = Convert.ToInt32(Console.ReadLine());

            QuadrantOfCoordinate(a, b);

            Console.Read();

        }
    }
}
