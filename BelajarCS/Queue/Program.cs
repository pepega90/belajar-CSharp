using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Queue
{
    /* Queue
     * queue adalah generic FIFO (first in first out) collection class yang ada di System.Collections.Generic namespace
     * queue bisa di analogikan seperti urutan orang yang mengantri di ATM untuk mengambil uang
     * jadi item pertama yang di tambahkan di queue (enqueued) akan jadi item yang pertama juga yang di hilangkan dari (dequeued) queue
     * Beberapa method yang berguna di Queue
     * Enqueue(), menambah item ke urutan terakhir di queue
     * Dequeue(), menghapus item pertama di queue dan mengembalikan item pertama tersebut
     * Contains(), menge-check jika suatu item sudah ada di queue
     * Peek(), mengembalikan item pertama di queue tetapi tidak menghapusnya
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

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            //Customer c1 = queueCustomers.Dequeue();
            //Console.WriteLine(c1.ID + " - " + c1.Name);
            //Console.WriteLine("Total item in queue = {0}", queueCustomers.Count);

            //Customer c1 = queueCustomers.Peek();
            //Console.WriteLine(c1.ID + " - " + c1.Name);
            //Console.WriteLine("Total item in queue = {0}", queueCustomers.Count);

            //Customer c2 = queueCustomers.Peek();
            //Console.WriteLine(c2.ID + " - " + c2.Name);
            //Console.WriteLine("Total item in queue = {0}", queueCustomers.Count);

            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exist");
            } else
            {
                Console.WriteLine("ga ada");
            }

            //foreach (Customer c in queueCustomers)
            //{
            //    Console.WriteLine(c.ID + " - " + c.Name);
            //    Console.WriteLine("Total item in queue = {0}", queueCustomers.Count);
            //}
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
