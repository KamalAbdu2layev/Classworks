using System;
using ClassWork_04_05_2022.Models;
using System.IO;
using Newtonsoft.Json;

namespace ClassWork_04_05_2022
{
    class Program 
    {

        static void Main(string[] args)
        {

            string root = @"C:\Users\tu1h43v7y\Desktop\Classworks\ClassWork_04_05_2022\Files";
            string fileName = @"C:\Users\tu1h43v7y\Desktop\Classworks\ClassWork_04_05_2022\Files\Database.json";

            //Directory.CreateDirectory(root);
            //if (!File.Exists(fileName))
            //{
            //    using (FileStream fs = File.Create(fileName))
            //    {

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File alredy exist!!!");
            //}

            Employee employee = new Employee()
            {
                Name = "Name1",
                Salary = 999.99
            };
            Employee employee2 = new Employee()
            {
                Name = "Name2",
                Salary = 888.88
            };

            Depatment depatment = new Depatment();

            depatment.employees.Add(employee);
            depatment.employees.Add(employee2);

            string json = JsonConvert.SerializeObject(depatment);

            //using (StreamWriter streamWriter = new StreamWriter(fileName))
            //{
            //    streamWriter.WriteLine(json);
            //}

            Depatment info = JsonConvert.DeserializeObject<Depatment>(json);
            //foreach (Employee item in info.employees)
            //{
            //    item.ShowInfo();
            //}
            for (int i = 0; i < depatment.employees.Count; i++)
            {
                if (depatment.employees[i].Id == 1)
                {
                    depatment.employees[i].ShowInfo();
                }
            }

        }
    }
}
