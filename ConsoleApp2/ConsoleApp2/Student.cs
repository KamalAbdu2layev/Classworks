using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student:Person
    {
        private int _id;
        public int Id { get; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        string[] lessans = new string[0];
    }
}
