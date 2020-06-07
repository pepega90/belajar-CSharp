using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.NullableType
{
    class Program
    {
        static void Main()
        {
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("not major");
            }
            else
            {
                Console.WriteLine("user did not answer the question");
            }

            // Nullable coalesing operator (??)
            int? TicketOnSale = 100;
            int AvaiableTickets = TicketOnSale ?? 0;

            //if (TicketOnSale == null)
            //    AvaiableTickets = 0;
            //else
            //    AvaiableTickets = (int)TicketOnSale;

            Console.WriteLine("Avaiable Tickets {0}", TicketOnSale);
        }
    }
}
