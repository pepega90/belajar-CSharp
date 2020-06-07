using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Structs
{
    /* Struct, pada dasarnya seperti class. dimana ia bisa memilki field, property, method dan
     * constructor. Struct adalah value type sedangkan Class adalah refrence type
     * Struct disimpan di Stack sedangkan Class di simpan di Heap
     * Struct tidak bisa memiliki destructor sedangkan Class bisa
     * Constructor Struct tidak bisa parameterless (tidak bisa kosong, harus langsung di initialize) sedangkan Class bisa
     * Struct tidak bisa melakukan inheritance ke Class lain, sedangkan Class bisa. Namun keduanya bisa melakukan inheritace ke interface
     * Contoh Struct adalah int (System.Int32), double (System.Double) etc
     * Struct tidak bisa melakukan inheritance ke Struct lainnya (Struct adalah sealed type)
     */

    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetail()
        {
            Console.WriteLine("Id = {0}, dan Nama = {1}", _id, _name);
        }
    }

    class Program
    {
        static void Main()
        {
            // beberapa cara untuk membuat object

            // Passing Value melalui argument di method constructor
            Customer c = new Customer(101, "Aji");
            c.PrintDetail();

            // Memberikan value 1 per-satu di properti masing-masing
            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "Yono";
            c2.PrintDetail();

            // Menggunakan Object Initializer
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Sigit"
            };
            c3.PrintDetail();
        }
    }
}
