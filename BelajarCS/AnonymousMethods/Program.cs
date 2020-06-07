using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelajarCS.AnonymousMethods
{
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


            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            //Employee emp = listEmployee.Find(emp => FindEmployee(emp));
            //Console.WriteLine("id = {0}, name = {1}", emp.ID, emp.Name);

            // dengan anonymous method kita bisa langsung memberikan delegate ke Find() method
            // delegate method juga bisa digunakan di event argument, biasanya ketika kita membuat 
            // windows form application
            Employee emp = listEmployee.Find(delegate (Employee emp) { return emp.ID == 102; });
            Console.WriteLine("id = {0}, name = {1}", emp.ID, emp.Name);
        }

        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}
    }



    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
