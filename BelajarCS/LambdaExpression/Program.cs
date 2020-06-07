using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BelajarCS.LambdaExpression
{
    /* Lambda expression (=>) di baca sebagai GOES TO
     * lambda expression biasanya saat berguna ketika menulis query LINQ
     * lalu kapan kita menggunakan lambda expression dibandingkan anonymous mehods?
     * kita gunakan lambda expression ketika kita ingin menggunakan parameter yang ada
     * kita gunakan anonymous methods ketika kita ingin menghilangkan parameter, dan hanya ingin menggunakan function bodynya saja
     */
    class Program
    {
        static void Main()
        {
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee{ID = 101, Name = "Mark" },
                new Employee{ID = 102, Name = "John" },
                new Employee{ID = 103, Name = "Mary" }
            };

            // disini lambda expression secara implicit mengubah e menjadi type employee
            //Employee employee = listEmployee.Find(e => e.ID == 102);
            // kita juga bisa meng-spesifikan type dari parameter secara explicit
            Employee employee = listEmployee.Find((Employee emp) => emp.ID == 102);
           
            Console.WriteLine("id = {0}, name = {1}", employee.ID, employee.Name);
            // contoh dimana kita menulis query LINQ denga lambda expression
            int count = listEmployee.Count(emp => emp.Name.StartsWith("M"));
            Console.WriteLine("Count = {0}", count);

        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
