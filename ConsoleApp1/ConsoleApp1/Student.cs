using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:person
    {
        private int point;
        public int Id  { get; set; }
        public int Point
        {
            get
            {
                return point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    point = value;
                
                        while (value < 0)
                        {
                            Console.WriteLine("age yeniden dail edin, menfi ola bilmez");
                            value = Convert.ToInt32(Console.ReadLine());
                        }
                    
                }
               
            }
        }
      public void ShowInfo()
        {
            Console.WriteLine($"id :-{Id} point  :- {Point}  name :-{Name}  surname :-{SurName}"); 
        }
        public Student(string name,string surname,int point,int id,int age)
        {
            Name = name;
            SurName = surname;
            Point = point;
            Id = id;
            _age = age;
        }
    }
}
