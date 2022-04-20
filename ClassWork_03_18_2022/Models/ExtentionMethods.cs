using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_03_18_2022.Models
{
    static class ExtentionMethods
    {
        static int num;
        static string word;

        public static bool IsOdd(this int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false ;
        }

        public static string ToCapitalize(this string word)
        {
           
            char [] chars = word.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            return new string(chars);

        }

        
        public static int[] GetValueIndexes(this string word, string letter)
        {
            int[] word = new int[word.Length];
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        if (word[i] == letter)
            //        {

            //        }
            //    }
            //}

            return { 1,2,4};
        }
}
