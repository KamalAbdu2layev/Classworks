using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_05_2022.Models
{
    class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} / Name: {Name} / Salary: {Salary}");
        }
    }
}
