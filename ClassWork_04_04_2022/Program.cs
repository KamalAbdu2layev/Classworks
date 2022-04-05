using System;
using System.Collections.Generic;
using ClassWork_04_04_2022.Models;

namespace ClassWork_04_04_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() {Name = "Kamal", Salary = 99999.99 };
            Console.WriteLine(employee.ShowInfo());

           List<Department> department = new List<Department>();

            Department department1 = new Department() { Name = "Kamal" };

        }
    }
}
