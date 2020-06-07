using System;
using System.Linq;

namespace BelajarCS.DoWhileLoop.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            string choice;
            int TotalCoffeCost = 0;
            do
            {
                int x;
                do
                {
                    Console.Write("1 - Small\n2 - Medium\n3 - Large  = ");
                    x = int.Parse(Console.ReadLine());

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
                            break;
                    }
                } while (x != 1 && x != 2 && x != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffe ? y/n");
                    choice = Console.ReadLine();
                    switch (choice.ToUpper())
                    {
                        case "Y":
                            break;
                        case "N":
                            break;
                        default:
                            Console.WriteLine("You choice is {0} is invalid", choice);
                            break;
                    }
                } while (choice != "Y" && choice != "N");
            } while (choice != "N");

            Console.WriteLine("Thanks for shoopig");
            Console.WriteLine("Tagihan mu tuan {0}", TotalCoffeCost);
        }
    }
}
