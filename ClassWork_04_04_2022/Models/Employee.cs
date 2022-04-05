using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_04_2022.Models
{
    class Employee
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            _id++;
            Id = _id;
        }
       public string ShowInfo()
        {
            return $"Id:{Id} - Name: {Name} - Salary: {Salary}";
        }

    }
}
