using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Introduction
{
    class Program
    {
        // Main method adalah entry point dari application kita
        // Kita tidak bisa memiliki 2 Main method

        static void Main1()
        {
            Console.WriteLine("Welcome to learn C# 102");
        }

        static void Main()
        {// C# akan mengeksekusi code dari sini
            Console.WriteLine("Welcome to learn C# 101");
            Main1();
        }// Sampai sini
    }
}
