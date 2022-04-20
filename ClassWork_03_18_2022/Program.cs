using System;
using ClassWork_03_18_2022.Models;

namespace ClassWork_03_18_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;
            string word = "dsaklmd131lkmkl";

            Console.WriteLine(n.IsOdd());
            Console.WriteLine(n.IsEven());
            Console.WriteLine(word.IsContainsDigit());
            Console.WriteLine(word.ToCapitalize());





        }
    }
}
