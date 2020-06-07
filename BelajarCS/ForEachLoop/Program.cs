using System;
using System.Linq;

namespace BelajarCS.ForEachLoop.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            string[] nama = new string[5] { "nisa", "tyas", "pepeg", "pepo", "omom" };

            foreach (string orang in nama)
            {
                Console.WriteLine(orang);
            }
        }
    }
}
