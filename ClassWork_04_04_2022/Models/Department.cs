using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_04_2022.Models
{
    class Department
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employee;
        public Department()
        {
            _id++;
            Id = _id;
            employee = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            employee.Add(emp);
        }



    }
}
