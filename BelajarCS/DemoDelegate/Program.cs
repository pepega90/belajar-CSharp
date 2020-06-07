using System;
using System.Collections.Generic;
using System.Linq;

namespace BelajarCS.Variabel.Program
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Aji", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "adi", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "mike", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "mari", Salary = 3000, Experience = 3 });

            IsPromotable promoted = new IsPromotable(Promote);
            IsPromotable naikGaji = new IsPromotable(KenaikanGaji);

            Employee.PromoteEmployee(empList, promoted);
            // kita juga bisa menggunakan lambda expression
            Employee.NaikGaji(empList, emp => emp.Salary < 5000);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KenaikanGaji(Employee emp)
        {
            if(emp.Salary < 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // Demo Delegate
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligiblePromoted)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligiblePromoted(employee))
                {
                    Console.WriteLine("{0} promoted", employee.Name);
                }
            }
        }

        public static void NaikGaji(List<Employee> employeeList, IsPromotable IsEligiblePromoted)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligiblePromoted(employee))
                {
                    Console.WriteLine("{0} Selamat kamu naik gaji", employee.Name);
                }
            }
        }
    }
}
