using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.BuiltInType
{
    class Program
    {
        static void Main()
        {
            // Boolean Types
            bool IsHandsome = true; // boolean hanya bisa menerima true atau false
            // Integral Types
            int i = 0;
            // Floating Types
            double d = 123.224232232;
            // Decimal Types
            decimal a = 3.14M;
            // String Types
            string Nama = "Aji Mustofa";
            // Verbaltim Literal
            string Palce = @"C:\ProgramFiles\PornHUB\Mspalomares";


            Console.WriteLine(d);
            Console.WriteLine(a);
            Console.WriteLine("Hai my name is {0}", Nama);
            Console.WriteLine($"Filenya berada di {Palce}");

            Console.WriteLine("Minimum Value dari tipe data integer = {0}",int.MinValue);
            Console.WriteLine("Maximum Value dari tipe data integer = {0}", int.MaxValue);
        }
    }
}
