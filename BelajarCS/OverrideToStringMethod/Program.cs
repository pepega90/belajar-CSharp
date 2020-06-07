using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.OverrideToStringMethod
{
    class Program
    {
        static void Main()
        {
            int num = 10;
            Console.WriteLine(num.ToString());

            Customer c1 = new Customer();
            c1.fn = "aji";
            c1.ln = "mustofa";

            Console.WriteLine(c1.ToString());
            Console.WriteLine(Convert.ToString(c1));
        }
    }

    public class Customer
    {
        public string fn { get; set; }
        public string ln { get; set; }

        public override string ToString()
        {
            return ln + ", " + fn;
        }
    }
}
