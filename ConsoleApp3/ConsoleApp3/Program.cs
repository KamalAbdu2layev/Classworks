using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("azad", "huseynov", 12);
            student.AddStudent(student);
            foreach (Student item in student.students)
            {
                Console.WriteLine(item.Name+"  "+item.SurName+" "+item.Age);
            }
        }
    }
}
