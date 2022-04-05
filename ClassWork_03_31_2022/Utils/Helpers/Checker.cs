using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils.Helpers
{
    public static class Checker
    {
        public static bool EmailChecker(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;

        }

        public static bool PasswordChecker(string password)
        {
            if (password.Length >=8 )
            {
                
                return true;
            }
            return false;
            
        }


    }
}

//Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|\]).{8,32}$");
//Match match = regex.Match(password);
//if (match.Success)
//{
//    return true;
//}
//return false;