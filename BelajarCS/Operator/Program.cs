using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Operator
{
    class Program
    {
        static void Main()
        {
            // Assignment operator (operator pemberian nilai)
            int i = 10;
            // Aritmatika operator (+, - , * , / , %)
            int num1 = 10;
            int num2 = 2;

            int Result = num1 / num2;
            int ResultRemainder = num1 % num2;
            Console.WriteLine("Result = {0}, Remainder = {1}", Result, ResultRemainder);
            // Operator Perbandingan (==, != ,> , < , >= , <=)
            int Number = 10;
            if (Number != 10)
                Console.WriteLine("Sama");
            else
                Console.WriteLine("Tidak Sama");

            // Operator Kondisional (&&, !, ||)
            int Angka = 10;
            int AnotherAngka = 220;
            if (Angka == 10 || AnotherAngka == 20)
                Console.WriteLine("Hello Universe");

            // Ternary Operator
            int num = 10;
            bool IsNumber10 = num == 10 ? true : false;
            Console.WriteLine(IsNumber10);
        }
    }
}
