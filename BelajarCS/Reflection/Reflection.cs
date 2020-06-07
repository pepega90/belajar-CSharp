using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BelajarCS.Reflection
{
    /* refleksi adalah kemampuan memeriksa metadata rakitan saat runtime. 
     * itu digunakan untuk menemukan semua jenis dalam suatu rakitan dan atau secara dinamis memanggil metode dalam suatu rakitan.
     * Kegunaan reflection
     * 1. ketika Anda drag dan drop tombol pada win forms atau aplikasi asp.net. Jendela properti menggunakan refleksi untuk menampilkan semua properti dari kelas tombol. 
     * jadi, refleksi banyak digunakan oleh para IDE atau desainer UI.
     * 2. labe binding dapat dicapai dengan menggunakan refleksi. Anda dapat menggunakan refleksi untuk secara dinamis membuat instance dari suatu tipe, tentang yang kami tidak memiliki informasi pada waktu kompilasi. 
     * jadi, refleksi memungkinkan Anda untuk menggunakan kode yang tidak tersedia pada waktu kompilasi.
     * 3. pertimbangkan contoh di mana kami memiliki dua implementasi alternatif dari sebuah antarmuka. 
     * Anda ingin mengizinkan pengguna untuk memilih satu atau yang lain menggunakan file konfigurasi. 
     * dengan refleksi, Anda cukup membaca nama kelas yang implemntasinya ingin Anda gunakan dari file konfigurasi, dan instantiate dan instance dari kelas itu. 
     * ini adalah contoh lain untuk late binding menggunakan reflection
     */
    class Reflection
    {
        static void Main()
        {

            //Type T = Type.GetType("BelajarCS.Reflection.Customer");
            //Type T = typeof(Customer);
            Customer c1 = new Customer();
            Type T =  c1.GetType();

            Console.WriteLine("Full name = {0}", T.FullName);
            Console.WriteLine("Name = {0}", T.Name);
            Console.WriteLine("Namespace = {0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties in customer class");
            PropertyInfo[] propertiesInfo = T.GetProperties();

            foreach (PropertyInfo property in propertiesInfo)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Methods in customer class");
            MethodInfo[] methodsInfo = T.GetMethods();

            foreach (MethodInfo method in methodsInfo)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Methods in customer class");
            ConstructorInfo[] constructorInfo = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructorInfo)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Customer()
        {
            this.ID = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.ID);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
