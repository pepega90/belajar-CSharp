using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace BelajarCS.Collections
{
    /* List
     * list adalah salah satu generic collection yang ada di System.Collections.Generis namespace
     * ada beberapa generic collection di class tersebut di antaranya;
     * 1. Dictionary
     * 2. List
     * 3. Stack
     * 4. Queue etc
     * list digunakan untuk membuat collection dari semua tipe data
     * misalkan kita bisa membuat list dari string, integer, dan juga custom type
     * object bisa di simpan di list dan di akses dari index
     * tidak seperti array, list bisa tumbuh sizenya secara otomatis
     * list juga mempunyai method untuk mencari, mengurutkan, manipulasi list
     */
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Aji",
                Salary = 6000,
                Type = "Retail"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Sigit",
                Salary = 7000,
                Type = "Retail"

            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rehan",
                Salary = 5000,
                Type = "Retail"

            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "tyas",
                Salary = 5000,
                Type = "Coorporate"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "gina",
                Salary = 3500,
                Type = "Coorporate"
            };

            // pembahasan list pada part 74 (list)
            // array tidak tumbuh secara otomatis, dia hanya akan fix sizenya, sesuai yang sudah di tentukan
            //Customer[] customers = new Customer[2];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            //List<Customer> customers = new List<Customer>(2);
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);
            //customers.Insert(0, customer3);

            // kita juga bisa menambahkan list dari class yang melakukan inherit ke class yang mempunyai list
            //Cust c = new Cust();
            //customers.Add(c);

            //Customer c = customers[0];
            //Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.ID, c.Name, c.Salary);

            //Console.WriteLine(customers.IndexOf(customer3, 1, 3));

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.ID, c.Name, c.Salary);
            //}

            // pembahasan list pada part 75 (list part 2)
            //List<Customer> customers = new List<Customer>(2);
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);

            // Contains(), digunakan untuk mengecek item apakah ada di list. mengembalikan boolean. 
            //if (customers.Contains(customer3))
            //{
            //    Console.WriteLine("ada");
            //} else
            //{
            //    Console.WriteLine("tidk ada");
            //}

            // Exists(), digunakan untuk mencari item dari list berdasarkan suatu kondisi. mengembalikan boolean
            //if (customers.Exists(cust => cust.Name.StartsWith("R")))
            //{
            //    Console.WriteLine("ada");
            //}
            //else
            //{
            //    Console.WriteLine("tidk ada");
            //}

            // Find(), digunakan untuk mencari item dari list bedasarkan suatu kondisi, mengembalikan item yang pertama kali match dengan kondisi ditemukan
            //Customer c = customers.Find(cust => cust.Salary > 5000);
            //Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.ID, c.Name, c.Salary);

            // FindLast(), digunakan untuk mencari item dari list bedasarkan suatu kondisi di mulai dari akhir list, mengembalikan item yang pertama kali match dengan kondisi ditemukan
            //Customer c = customers.FindLast(cust => cust.Salary > 5000);
            //Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.ID, c.Name, c.Salary);

            // FindAll(), digunakan untuk mencari semua item dari list bedasarkan suatu kondisi, mengembalikan list dari kondisi yang match
            //List<Customer> c = customers.FindAll(cust => cust.Salary > 5000);
            //foreach (Customer a in c)
            //{
            //    Console.WriteLine("Id = {0}, name = {1}, salary = {2}", a.ID, a.Name, a.Salary);
            //}

            // FindIndex(), digunakan untuk mencari index item dari list berdasarkan suatu kondisi, mengembalikan item dari list yang match kondisi
            //int c = customers.FindIndex(cust => cust.Salary > 5000);
            //Console.WriteLine("Index = {0}", c);

            // FindLastIndex(), digunakan untuk mencari index item dari list terakhir berdasarkan suatu kondisi, mengembalikan item dari list yang match kondisi
            //int c = customers.FindLastIndex(cust => cust.Salary > 5000);
            //Console.WriteLine("Index = {0}", c);

            // ToList(), convert array ke list
            //Customer[] arrCust = { customer1, customer2, customer3 };
            //List<Customer> customerList = arrCust.ToList();
            //foreach (Customer c in customerList)
            //{
            //    Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.ID, c.Name, c.Salary);
            //}

            // ToArray(), covert list ke array
            //List<Customer> listCustomer = new List<Customer>
            //{
            //    customer1,
            //    customer2,
            //    customer3
            //};

            //Customer[] arrCust = listCustomer.ToArray();

            // ToDictionary(), convert list ke dictionary
            //List<Customer> listCustomer = new List<Customer>
            //{
            //    customer1,
            //    customer2,
            //    customer3
            //};

            //Dictionary<int, Customer> dictList = listCustomer.ToDictionary(c => c.ID);
            //foreach (KeyValuePair<int,Customer> c in dictList)
            //{
            //    Console.WriteLine("Id = {0}, name = {1}, salary = {2}", c.Value.ID, c.Value.Name, c.Value.Salary);
            //}

            // pembahasan pada part 76 (working with generic list class and ranges in c#)
            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);


            //List<Customer> coorporateCustomer = new List<Customer>();
            //coorporateCustomer.Add(customer4);
            //coorporateCustomer.Add(customer5);

            // AddRange(), memungkinkan kita untuk menambah list baru yang nantinya akan di taruh di akhir
            //customers.AddRange(coorporateCustomer);

            // GetRange(), memungkinkan kita untuk mengambil multiple item di list, argument pertama adalah index awal pengambilan
            // argument ke dua adalah berapa banyak item yang ingin di ambil
            //List<Customer> coorCustomer = customers.GetRange(0, 3);

            // InsertRange(), mirip dengan Insert() bedanya kita bisa menambahkan list baru ke spesifik index
            //customers.InsertRange(3, coorporateCustomer);

            // Remove(), memungkinkan kita untuk menghapus single item
            //customers.Remove(customer1);

            // RemoveAt(), menghapus single item di spesifik index
            //customers.RemoveAt(3);

            // RemvoeAll(), menghapus item dengan spesifik kondisi
            //customers.RemoveAll(item => item.Type == "Coorporate");

            // RemoveRange(), menghapus multiple item berdasarkan index tertentu
            // argumen pertama index awal penghapusan, kedua berapa item yang ingin di hapus
            //customers.RemoveRange(3, 2);

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine
            //        ("Id = {0}, name = {1}, salary = {2}, type = {3}", c.ID, c.Name, c.Salary, c.Type);
            //}

            // pembahasan pada part 77 (sort a list of simple types in c#)
            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);

            //Console.WriteLine("Before sorting");
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine
            //        (c.Salary);
            //}

            //customers.Sort();
            //Console.WriteLine("After sorting");
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine
            //        (c.Salary);
            //}
            //customers.Reverse();
            //Console.WriteLine("Descending sorting");
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine
            //        (c.Salary);
            //}

            //urutNama uruting = new urutNama();
            //customers.Sort(uruting);

            //Console.WriteLine("sort by name sorting");
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine
            //        (c.Name);
            //}

            //List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            //Console.WriteLine("Sebelum di sorting");
            //foreach (int c in numbers)
            //{
            //    Console.WriteLine(c + " ");
            //}
            //// Sort(), memungkinkan kita mengurutkan data dari yang terkecil ke yang terbesar (ascending)
            //numbers.Sort();

            //Console.WriteLine("Sesudah di sorting");
            //foreach (int c in numbers)
            //{
            //    Console.WriteLine(c + " ");
            //}
            //// Reverse(), memungkinkan kita mengurutkan data dari yang terbesar ke yang terkecil (descending), tetapi sebelumnya kita harus melakukan sort terlebih dahulu
            //numbers.Reverse();

            //Console.WriteLine("Descending sorting");
            //foreach (int c in numbers)
            //{
            //    Console.WriteLine(c + " ");
            //}

            // kita juga bisa meng-sorting string
            //List<string> alfa = new List<string>() { "B", "F", "D", "E", "A", "C" };

            //Console.WriteLine("before sorting");
            //foreach (string c in alfa)
            //{
            //    Console.WriteLine(c + " ");
            //}
            //alfa.Sort();
            //Console.WriteLine("after sorting");
            //foreach (string c in alfa)
            //{
            //    Console.WriteLine(c + " ");
            //}
            //alfa.Reverse();
            //Console.WriteLine("descending sorting");
            //foreach (string c in alfa)
            //{
            //    Console.WriteLine(c + " ");
            //}

            // pembahasan 79 comparison dengan delegate
            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer3);
            //customers.Add(customer1);
            //customers.Add(customer2);


            // cara  pertama
            //Comparison<Customer> customerDelegateCompare = new Comparison<Customer>(CompareCustomer);

            //customers.Sort(customerDelegateCompare);
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine(c.ID + " ");
            //}

            // cara kedua
            //customers.Sort(delegate (Customer c1, Customer c2)
            //{
            //    return c1.ID.CompareTo(c2.ID);
            //});

            // cara ketiga lambda expression
            //customers.Sort((x, y) => x.ID.CompareTo(y.ID));
            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine(c.ID + " ");
            //}

            // part 80, beberapa method berguna di list collection class
            List<Customer> customers = new List<Customer>(100);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            // TrueForAll(), mengembalikan boolean (True or False) jika lolos dari suatu kondisi tertentu
            //Console.WriteLine("Seluruh customer salary lebih besar dari 5000 = {0}", 
            //    customers.TrueForAll(x => x.Salary > 3000));

            // AsReadOnly(), mengembalikan ReadOnlyCollection yang nantinya kita hanya bisa get list dan tidak bisa melakukan set ke list
            // beberapa method seperti Add() dan Remove() pun tidak ada karena kita jadikan ReadOnly
            //ReadOnlyCollection<Customer> readOnlyCustomer = customers.AsReadOnly();
            // akan terjadi error jika kita menggunakan method tersebut
            //readOnlyCustomer.Add();
            //readOnlyCustomer.Remove();

            Console.WriteLine("Capacity customers sebelum trim = {0}", customers.Capacity);
            // menetapkan kapasitas ke jumlah elemen aktual dalam daftar, jika jumlah itu kurang dari nilai ambang batas
            customers.TrimExcess();
            Console.WriteLine("Capacity customers setelah trim = {0}", customers.Capacity);


        }
        // method untuk cara pertama, comparison dengan delegate
        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }

    // kita juga bisa membuat custom compare milik kita sendiri dengan inherit dari IComparer interface
    public class urutNama: IComparer<Customer>
    {
        public int Compare(Customer X, Customer Y)
        {
            return X.Name.CompareTo(Y.Name);
        }
    }

    // jika kita ingin melakukan sorting pada complex type kita harus inherit dari IComparable interface
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {

            return this.Salary.CompareTo(other.Salary);
            //if (this.Salary > other.Salary)
            //{
            //    // jika current salary lebih besar, maka dia di taruh di belakang
            //    return 1;
            //}
            //else if (this.Salary < other.Salary)
            //{
            //    // jika current salary lebih kecil, maka dia di taruh di depan
            //    return -1;
            //} else
            //{
            //    // jika tidak besar dan tidak kecil, maka sama dan tidak di usah di urutkan
            //    return 0;
            //}
        }
    }

    //public class Cust : Customer { }
}
