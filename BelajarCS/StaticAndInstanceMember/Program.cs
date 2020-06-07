using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.StaticAndInstanceMember
{
    class Circle
    {
        /* jika member class memiliki static keyword di depannya, maka itu adalah static member
         * jika tidak maka itu adalah instance member. kita bisa menggunakan static keyword untuk 
         * field (variabel), property, constructor, atau pun method. ketika kita membuat static member, itu artinya setiap
         * kali kita membuat instance object dari class itu, maka object itu akan memiliki static member tersebut
         */

        public static float _PI;
        int _Radius;

        // static constructor akan di invoke hanya sekali, sebelum instance constructor
        static Circle()
        {
            Console.WriteLine("static constructor invoke");
            Circle._PI = 3.141F; 
        }

        // ini instance contructor
        public Circle(int Radius)
        {
            Console.WriteLine("instance constructor invoke");
            this._Radius = Radius;
        }


        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }

    class Program
    {
        static void Main()
        {
            //Circle c1 = new Circle(5);
            //float Area = c1.CalculateArea();

            //Console.WriteLine($"Area = {Area}");

            //Circle c2 = new Circle(6);
            //float Area2 = c2.CalculateArea();

            //Console.WriteLine($"Area2 = {Area2}");
            Console.WriteLine(Circle._PI);
        }
    }
}
