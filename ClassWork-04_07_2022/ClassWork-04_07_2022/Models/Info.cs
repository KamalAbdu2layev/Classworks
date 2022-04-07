using System;
using System.Collections.Generic;
using System.Text;
using ClassWork_04_07_2022.Models;

namespace ClassWork_04_07_2022.Models
{
    public class Info
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public Address address;
        public string Phone { get; set; }
        public string Website { get; set; }

        public Info()
        {
            address = new Address();
        }
    }
}
