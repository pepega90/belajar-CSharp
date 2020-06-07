using System;
using System.Linq;

namespace BelajarCS.WhileLoop.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.Write("Please enter your target = ");
            int i = int.Parse(Console.ReadLine());

            int Start = 0;

            while(Start <= i)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }
    }
}
