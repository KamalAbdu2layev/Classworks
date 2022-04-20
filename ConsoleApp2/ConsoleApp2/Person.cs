using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
    }
}
