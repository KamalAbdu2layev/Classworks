using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Teacher:Person
    {
        private int _id;
        private int _experience;
        public int Id { get; }
        public Teacher()
        {
            _id++;
            Id = _id;
        }
        public int Experience
        {
            get=> _experience;
            set
            {
                if (value > 0 && value <= 80)
                {
                    _experience = value;
                }
            }
            
        }
    }
}
