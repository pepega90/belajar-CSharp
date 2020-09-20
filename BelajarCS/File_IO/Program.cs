using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BelajarCS.File_IO
{
    class Program
    {
        static void Main()
        {
            // Contoh read file, melalui StreamReader class
            //try
            //{
            //    using (StreamReader sr = new StreamReader(@"C:\testing\One.txt"))
            //    {
            //        Console.WriteLine(sr.ReadToEnd());
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("File can't be read!");
            //    Console.WriteLine(e.Message);
            //}

            // Contoh write file, melalui StreamWriter class
            string[] pacar = { "Nisa", "Gina" };

            using (StreamWriter streamWriter = new StreamWriter(@"C:\testing\One.txt"))
            {
                foreach (var item in pacar)
                {
                    streamWriter.WriteLine("Nama = {0}", item);
                }
            }


            StreamReader reader = new StreamReader(@"C:\testing\One.txt");
            try
            {
                // Read file yang tadi kita write di code di atas
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception e)
            {

                Console.WriteLine("File can't be read");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Close read file
                reader.Close();
            }
        }
    }
}
