using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityForAdmission
{
    /// <summary>
    /// program to check eligibility for admission to a professional course
    /// </summary>
    public class Program
    {
        static void Admission(int x, int y, int z)
        {
            if (x >= 65 && y >= 55 && z >= 50)
                Console.WriteLine("Congratulations! You are eligible to take admission ");
            else if ((x + y + z) >= 180)
                Console.WriteLine("Congratulations! You are eligible to take admission ");
            else if ((x + y) >= 140 || (x + z) >= 140)
                Console.WriteLine("Congratulations! You are eligible to take admission ");
            else
                Console.WriteLine("Sorry! You are not eligible for this course");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter marks in Maths: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks in physics: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks in Chemistry ");
            int c = Convert.ToInt32(Console.ReadLine());

            Admission(m, p, c);

            Console.Read();
        }
    }
}
