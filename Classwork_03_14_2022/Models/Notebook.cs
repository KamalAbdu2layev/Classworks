using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_03_14_2022.Models
{
    internal class Notebook : Product
    {
        public string brandName;
        public string model;
        public int ram;
        public int storage;

        public Notebook(string brandName, double price, int count):base(price, count)
        {
            this.brandName = brandName;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Brand name: {brandName} \nPrice: {price} \nCount: {count}");
        }
    }
}
