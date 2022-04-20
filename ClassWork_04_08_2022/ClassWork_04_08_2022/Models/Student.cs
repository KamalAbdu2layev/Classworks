using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_08_2022.Models
{
    class Student
    {
        public int No { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, int> exam;

        public Student()
        {
            exam = new Dictionary<string, int>();
        }

        public void AddExam(string examName, int point)
        {
            exam.Add(examName, point);
        }

        public void GetExamResult(string FullName)
        {
            foreach (var item in exam)
            {
                if (item.Key == FullName)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }

        public void GetExamAv()
        {
            foreach (var item in exam)
            {

            }
        }

    }
}
