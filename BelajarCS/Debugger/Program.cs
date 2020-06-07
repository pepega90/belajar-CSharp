using System;
using System.Linq;

namespace BelajarCS.Debugger.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            string username = "jonathan";
            //int[] arr = new int[1];
            int[] arr = new int[2];

            arr[0] = 12;
            arr[1] = 10;

            Console.WriteLine(username + " punya " + arr[0] + " istri dan " + arr[1] + " anak");
        }
    }
}
