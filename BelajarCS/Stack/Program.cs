using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Stack
{
    /* Stack
     * stack adalah generic LIFO (last in first out) collectionc class yang ada di System.Collections.Generic namespace
     * stack bisa di analogikan seperti tumpukan piring jika kita menambahkan piring pertama kali di atas piring yang sudah ada
     * maka ketika kita ingin mengambil piring, piring yang tadi kita tambahkah barusan lah yang akan kita ambil
     * jadi item terakhir yang di push ke stack, adalah item pertama yang di hilangkan di stack
     * Beberapa method yang berguna di Stack
     * Push(), digunakan untuk menambah item di atas stack
     * Pop(), menghapus item dan mengambalikan item di atas stack
     * Contains(), untuk menge-check apakah item sudah ada di stack
     * Peek(), mengembalikan item di atas stack, namun tidak menghapusnya
     */
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Aji",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Sigit",
                Gender = "Male"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rehan",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "tyas",
                Gender = "Female"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "gina",
                Gender = "Female"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            //Customer c1 = stackCustomers.Pop();
            //Console.WriteLine("id = {0}, name = {1}", c1.ID, c1.Name);
            //Console.WriteLine("Total item in stack = {0}", stackCustomers.Count);

            //Customer c1 = stackCustomers.Peek();
            //Console.WriteLine("id = {0}, name = {1}", c1.ID, c1.Name);
            //Console.WriteLine("Total item in stack = {0}", stackCustomers.Count);

            //if (stackCustomers.Contains(customer1))
            //{
            //    Console.WriteLine("ada");
            //} else
            //    Console.WriteLine("tidak ada");

            foreach (Customer c in stackCustomers)
            {
                Console.WriteLine("id = {0}, name = {1}", c.ID, c.Name);
                Console.WriteLine("Total item in stack = {0}", stackCustomers.Count);
            }

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
