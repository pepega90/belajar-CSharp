using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BelajarCS.OperatorOverload
{
    class Anak
    {
        int umur;
        string name;

        public Anak()
        {

        }

        public Anak(string name, int umur)
        {
            this.umur = umur;
            this.name = name;
        }

        public void PrintAnak()
        {
            Console.WriteLine("Nama = {0}, Umur = {1}", this.name, this.umur);
        }

        /* Beberapa operator yang bisa di overload
         * +,-,!,~,++,-- : Operator unary ini mengambil satu operan dan dapat di overload
         * +, -, *, /, % : Operator biner ini menggunakan satu operand dan dapat di overload
         * ==, !=, <, >, <=, >= : Operator pembanding bisa di overload
         */

        // Contoh operator overload. untuk operator aritmatika
        public static Anak operator +(Anak anak1, Anak anak2)
        {
            Anak anak = new Anak();
            anak.name = "Aji";

            anak.umur = anak1.umur + anak2.umur;

            return anak;

        }

        /* Untuk operator logika, kita harus membuat lawannya dari operator tersebut
         * misal, ketika kita membuat operator overload untuk lebih besar (>). maka harus ada juga operator
         * overload untuk lebih kecil (<).
         */
        public static bool operator >(Anak anak1, Anak anak2)
        {
            bool status = false;

            if (anak1.umur > anak2.umur)
            {
                status = true;
            }

            return status;
        }


        public static bool operator <(Anak anak1, Anak anak2)
        {
            bool status = false;

            if (anak1.umur < anak2.umur)
            {
                status = true;
            }

            return status;
        }

    }

    class Program
    {
        static void Main()
        {
            Anak anak1 = new Anak("Pepe", 17);
            Anak anak2 = new Anak("Gina", 19);
            Anak anak3 = anak1 + anak2;
            anak1.PrintAnak();
            anak2.PrintAnak();
            anak3.PrintAnak();

            if (anak1 > anak2)
                Console.WriteLine("Anak 1 lebih tua dari anak 2");
            else
                Console.WriteLine("Anak 2 lebih tua dari anak 1");
        }
    }
}
