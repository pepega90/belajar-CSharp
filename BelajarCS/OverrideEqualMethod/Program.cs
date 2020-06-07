using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.OverrideEqualMethod
{
    class Program
    {
        static void Main()
        {
            Customer c1 = new Customer();
            c1.fn = "aji";
            c1.ln = "mus";

            Customer c2 = new Customer();
            c2.fn = "aji";
            c2.ln = "mus";

            int i = 10;
            int j = 10;

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
        }
    }

    public class Customer
    {
        public string fn { get; set; }
        public string ln { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Customer))
                return false;

            return fn == ((Customer)obj).fn &&
                ln == ((Customer)obj).ln;
        }

        public override int GetHashCode()
        {
            return fn.GetHashCode() ^ ln.GetHashCode();
        }
    }
}
