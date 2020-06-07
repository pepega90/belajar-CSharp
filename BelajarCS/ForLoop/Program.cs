using System;
using System.Linq;

namespace BelajarCS.ForLoop.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            for(int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
                
            }
        }
    }
}
