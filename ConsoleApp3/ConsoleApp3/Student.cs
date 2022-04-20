using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        public string Fullname;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Student(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;


        }
        public Student[] students = new Student[0];
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
      
    }
}
