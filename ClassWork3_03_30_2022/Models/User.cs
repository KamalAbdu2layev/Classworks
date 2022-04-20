using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;
using ClassWork3_03_30_2022.Interfaces;
namespace ClassWork3_03_30_2022.Models
{
    internal class User: IEntity
    {
        private static int _id;
        public int Id { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public User(string username, string email, Role role)
        {
            _id++;
            Id = _id;
            Username = username;
            Email = email;
            Role = role;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Username: {Username} / Email:{Email} / Role: {Role}");
        }

    }
}
