using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class person
    {
        public string Name { get; set; }
        private  int Age;
        public string SurName { get; set; }
        public  int _age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value > 0)
                {
                    Age = value;
                }
                
            }
        }
    }
}
