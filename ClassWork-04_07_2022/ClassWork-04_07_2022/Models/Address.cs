using System;
using System.Collections.Generic;
using System.Text;
using ClassWork_04_07_2022.Models;

namespace ClassWork_04_07_2022.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public Geo geo;

        public Address()
        {
            geo = new Geo();
        }

    }
}
