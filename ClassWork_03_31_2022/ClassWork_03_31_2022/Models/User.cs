using System;
using System.Collections.Generic;
using System.Text;
using ClassWork_03_31_2022.Interfaces;
using Utils.Helpers;

namespace ClassWork_03_31_2022.Models
{
    class User: IEntity
    {
        private static int _id;
        public int Id { get; }
        private string _email;
        public string Email 
        {
            get => _email;
            set
            {
                if (Checker.EmailChecker(value))
                {
                    _email = value;
                }
            }
        }
        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                if (Checker.PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }


    }
}
