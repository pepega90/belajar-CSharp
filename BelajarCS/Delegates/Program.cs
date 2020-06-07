using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Delegates
{
    // Delegate adalah type safe function pointer. delegate is refrence type
    // maksud dari type safe adalaha, signature dari delegate harus sama dengan function yang kita tunjuk (pointing)
    // Delegate mirip seperti class, kita bisa membuat instance dari delegate

    public delegate void HelloFunctionDelegate(string message);
    public delegate void SumDelegate(out int val1, out int val2);

    class Program
    {
        static void Main()
        {
            // untuk membuat delegate kita membuat instance dari delegate
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            SumDelegate sum = new SumDelegate(SumNumber);
            // secara otomatis function Hello akan di invoke dan delegate memberikan argumentnya
            del("Hello delegate");
            int num1, num2;
            sum(out num1, out num2);
            Console.WriteLine("num 1 = {0}, num2 = {1}", num1, num2);

        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        public static void SumNumber(out int val1, out int val2)
        {
            val1 = 5;
            val2 = 10;
        }
    }
}
