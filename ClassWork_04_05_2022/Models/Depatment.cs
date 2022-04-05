using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_05_2022.Models
{
    class Depatment
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees;

        public Depatment()
        {
            _id++;
            Id = _id;
            employees = new List<Employee>();
        }
    }
}
