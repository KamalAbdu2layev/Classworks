using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_03_28_2022.Models
{
    class Product
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public int Count { get; set; }
        public Product()
        {
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} / Price:{Price} / StockCount: {StockCount} / Count:{Count}");
        }

    }
}
