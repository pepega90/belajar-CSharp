using System;
using System.Collections.Generic;
using System.Text;
using Pe = Pepega;
using Po = Pepeg;

// Namespace digunakan untuk mengorganisir program kita
// dia juga digunakan untuk menghindari name clashes
namespace BelajarCS.NameSpaces
{
    class Program
    {
        static void Main()
        {
            // kita bisa menggunakan alias name, jika memiliki class dengan nama
            // yang sama
            Pe.ClassP.print();
            Po.ClassP.print();
        }
    }

   
}

namespace Pepega
{
    class ClassP
    {
        public static void print()
        {
            Console.WriteLine("pepega");
        }
    }
}

namespace Pepeg
{
    class ClassP
    {
        public static void print()
        {
            Console.WriteLine("pepeg");
        }
    }
}
