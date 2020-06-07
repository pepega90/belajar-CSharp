using System;
using System.Linq;

namespace BelajarCS.JumpingStatement.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            string[] nama = new string[5] { "nisa", "tyas", "pepeg", "pepo", "omom" };

            /* keyword jumping statement
             * break = memberhentikan suatu loop dengan kondisi tertentu
             * continue = melanjutkan suatu loop dengan kondisi tertentu
             * return = keluar dari suatu statement, dan juga bisa mengembalikan suatu value
             * throw = melempar error, mirip seperti return
             * goto = meng-skip suatu statement, dengan kondisi tertentu. kita harus membuat labeled code agar bisa menggunakan goto
             */

            foreach (string orang in nama)
            {
                if(orang == "pepeg")
                {
                    throw new ApplicationException();
                }
                Console.WriteLine(orang);
            }
            Console.WriteLine("ini akhir");
        }
    }
}
