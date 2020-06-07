using System;
using System.Linq;

namespace BelajarCS.SwitchStatement.Program
{

    class Program
    {

        static void Main(string[] args)
        {
         int TotalCoffeCost = 0;

        buyCoffe:
            Console.Write("1 - Small\n2 - Medium\n3 - Large  = ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid", x);
                    goto buyCoffe;
            }

        decide:
            Console.WriteLine("Do you want to buy another coffe ? y/n");
            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "Y":
                    goto buyCoffe;
                case "N":
                    break;
                default:
                    Console.WriteLine("You choice is {0} is invalid", choice);
                    goto decide;
            }

            Console.WriteLine("Thanks for shoopig");
            Console.WriteLine("Tagihan mu tuan {0}", TotalCoffeCost);
        }
    }
}
