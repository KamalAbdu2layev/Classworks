using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2_03_18_2022.Models
{
    internal class Student
    {
        private static int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id += 1;
            }
        }

        public string Name { get; set; }
        public string Surname { get; set; }

            string _groupno;
        public string GroupNo {
            get => _groupno; 
            set
            {
                if (CheckGroupNo(value) == true)
                {
                    _groupno = value;
                }
            }
                }

        public Student(string name, string surname, string groupNo)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Id = _id;
            Console.WriteLine(Id);
        }

        public static bool CheckGroupNo(string _groupno)
        {
            if(_groupno.Length == 5 && char.IsUpper(_groupno[0]) && char.IsUpper(_groupno[1]) && char.IsDigit(_groupno[2]) &&
                char.IsDigit(_groupno[3]) && char.IsDigit(_groupno[4]))
            {
                return true;
            }
            return false;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname} {GroupNo}");
        }

        

    }
}
