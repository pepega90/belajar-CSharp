using System;
using System.Linq;

namespace BelajarCS.IfElseStatement.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            int x = 7;
           if(x == 6)
            {
                Console.WriteLine("x is 6");
            }
           else if(x == 5)
            {
                Console.WriteLine("x is 5");
            }
           else if(x == 7)
            {
                Console.WriteLine("x is 7");
            }
           else
            {
                Console.WriteLine("ini dieksekusi jika kondisi false");
            }

           // Jika menggunakan (&& atau ||) operator, jika salah satu kondisi bernilai false/true, kita akan 
           // langsung print statement true. Jika menggunakan (& atau |). jika kondisi bernilai false/true, 
           // operator tetap akan mengecek kondisi setelahnya walaupun kondisi setelahnya bernilai false
        

            int num = 12;
            if (num == 12 | num == 20)
            {
                Console.WriteLine("selamat datang");
            }    
            else 
            {
                Console.WriteLine("Who are you?");
            }
                
        }
    }
}
