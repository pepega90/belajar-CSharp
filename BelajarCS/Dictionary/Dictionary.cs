using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BelajarCS.Dictionary
{
    /* Dictionary di C#
     * 1. dictionary adalah collection dari (key, value) pairs
     * 2. dictionary termasuk kedalam Generic
     * 3. dictionary class berada di System.Collection.Generic namespace
     * 4. dictionary menyediakan pencarian cepat untuk nilai menggunakan keys
     * 5. keys di dictionary harus unik
     * 
     * beberapa method di dictionary class
     * 1. TryGetValue()
     * 2. Count()
     * 3. Remove()
     * 4. Clear()
     * 5. menggunakan LINQ exstension methods di dictionary
     * 6. cara berbeda-beda untuk mengubah array menjadi dictionary
     */
    class Dictionary
    {
        static void Main()
        {

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "pop",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "bar",
                Salary = 3500
            };

            //Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            //dictionaryCustomer.Add(customer1.ID, customer1);
            //dictionaryCustomer.Add(customer2.ID, customer2);
            //dictionaryCustomer.Add(customer3.ID, customer3);

            // contoh meng-convery array di dictionary
            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            // tidak hanya array, kita juga bisa meng-convery list ke dictionary
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            // ketika kita ingin meng-convery array ke dictionary kita harus menyesuaikan key dan valuenya
            Dictionary<int, Customer> c = customers.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in c)
            {
                Console.WriteLine("key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("id = {0}, name = {1}, salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

            // argument TryGetValue(key yang ingin di cari, output parameter)
            //Customer cust;
            //if (dictionaryCustomer.TryGetValue(202, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //} else
            //{
            //    Console.WriteLine("key tidak ada di dictionary");
            //}

            // Count(), berfungsi untuk mengetahui total seluruh dictionary
            //Console
            //    .WriteLine
            //    ("Total items = {0}", 
            //    dictionaryCustomer.Count(kvp => kvp.Value.Salary > 4000));

            // Remove(), untuk menghapus 1 item dengan spesifik id di dictionary
            //dictionaryCustomer.Remove(102);

            // Clear(), untuk menghapus semua key dan value dictionary
            //dictionaryCustomer.Clear();

            // ketika kita ingin meloop semua dictionary menggunakan masing-masing keys nya
            // kita gunakan KeyValuePairs, selain itu kita juga bisa gunakan var keyword
            //foreach (Customer cust in dictionaryCustomer.Values)
            //{
            //    //Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //    //Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    //Console.WriteLine("-------------------------------------------------------------------");
            //}
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
