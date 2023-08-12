using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    /// <summary>
    ///  program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
    ///  The charge are as follow :
    ///  Unit Charge/unit
    ///  upto 199							@1.20
    ///  200 and above but less than 400		@1.50
    ///  600 and above                       @2.00
    ///  If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-
    /// </summary>
    struct CustomerInfo
    {
        private  int _id;
        private  string _name;
        private  double _unit;
        
        /// <summary>
        /// Prop
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            { _name = value; }
        }
        public int Id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }
        public double Unit
        {
            get
            { return _unit; }
            set
            { _unit = value; }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CustomerInfo C =new CustomerInfo();
            double res = 0;
            double suramount = 0;
            double total = 0;
            Console.Write("Enter Customer ID : ");

            C.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer name : ");
            C.Name = Console.ReadLine();
            Console.Write("Enter the electricity unit consumed by the Customer : ");
            C.Unit = Convert.ToDouble(Console.ReadLine());


            if (C.Unit < 200)
            {
                res = C.Unit * 1.20;
                Console.WriteLine("Amount charges @Rs. 1.20 per unit : " + res);
            }
            else if (C.Unit >= 200 && C.Unit < 400)
            {
                res = C.Unit * 1.50;
                Console.WriteLine("Amount charges @Rs. 1.50 per unit : " + res);
            }
            else if (C.Unit >= 400 && C.Unit < 600)
            {
                res = C.Unit * 1.80;
                Console.WriteLine("Amount charges @Rs. 1.80 per unit : " + res);
            }
            else if (C.Unit >= 600)
            {
                res = C.Unit * 2.00;
                Console.WriteLine("Amount charges @Rs. 2.00 per unit : " + res);
            }


            if (res > 400)
                suramount = res * 0.15;
            else
                suramount = 100;

            Console.WriteLine("Surcharge Amount : " + suramount);

            total = res + suramount;
            Console.WriteLine("Net amount paid by the customer : " + total);

            Console.Read();

        }
    }
}
