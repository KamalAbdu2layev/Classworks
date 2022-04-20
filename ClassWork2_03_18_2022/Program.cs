using System;
using ClassWork2_03_18_2022.Models;
namespace ClassWork2_03_18_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Kamal", "Abdullayev", "AP103");

            Student student2 = new Student("Kamal", "Abdullayev", "AU132");
            Console.WriteLine(student2.CheckGroupNo("_groupno"));
            student2.StudentInfo();
            
            

        }
    }
}
