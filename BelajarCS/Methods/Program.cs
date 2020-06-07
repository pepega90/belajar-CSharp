using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Methods
{
    class Program
    {
        /* penulisan method
          * access-modifier return-type method-name (parameters)
          * {
          *    method body
          * }
          * contoh:
          * public int SumTwoInteger(int val1, int val2)
          * {
          *     return val1 + val2
          * }
          * 
          * jika suatu method memiliki static keyword (disebut static method), method itu bisa di invoke langsung dari classnya
          * jika suatu method tidak memiliki static keyword (disebut instance method), method itu bisa di invoke setelah kita
          * membuat instance dari classnya
          */

        public static void AngkaGenap(int Target)
        {
            int Start = 0;
            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        static void Main()
        {
            Program p = new Program();
            int num1 = 5;
            int num2 = 10;
            int num = p.Add(num1, num2);

            Program.AngkaGenap(20);
            Console.WriteLine($"Result {num}, num1 value = {num1} num2 value = {num2}");
        }
    }
}
