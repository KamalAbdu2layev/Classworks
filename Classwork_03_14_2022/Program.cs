using System;
using Classwork_03_14_2022.Models;
namespace Classwork_03_14_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Acer", 1999.99, 50);
            //notebook.GetInfo();

            Console.WriteLine("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            

            Notebook[] computersInfo = new Notebook[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Brand Name: ");
                string brandName = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Computer Count: ");
                int cont = Convert.ToInt32(Console.ReadLine());

                computersInfo[i] = new Notebook(brandName,  price, count);
            }
            
            foreach (var item in computersInfo)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine($"Brand Name: {item.brandName} \nPrice: {item.price} \nComputer Count: {item.count}");
            }
        }
    }
}   
