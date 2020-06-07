using System;
using System.Linq;

namespace BelajarCS.UsingObject.Program
{
   
    class Program
    {
  
        static void Main(string[] args)
        {
            /* Object adalah refrence type, maksudnya ketika kita membuat object
             * lalu merefrensika object yang pertama kita buat ke object yang kedua
             * mereka akan memiliki lokasi memory yang sama (pointer yang sama)
             * itu sebabnya ketika mengubah salah satu property dari object pertama 
             * lewat object kedua, mereka akan mempunyai property yang sama.
             * lain halnya jika kita membuat object yang berbeda namun memiliki property dan method yang sama persis
             * itu akan berbeda, kenapa? karena mereka memiliki alokasi memory address yang berbeda
             */
            MyClass MyObject = new MyClass(8, 5);

            Console.WriteLine(MyObject.Total);

            //MyObject.Value1 = 4;
            //MyObject.Value2 = 8;

            //Console.WriteLine(MyObject.doMath(5, 4, 11));

            //int x = 8;
            //int y = x;

            //y++;

            //Console.WriteLine(x == y);
        }
    }
}
