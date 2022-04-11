using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pr1 = new Person();
            int age;
            do
            {
                Console.WriteLine("insanin yasi daxil edin:");
               age = Convert.ToInt32(Console.ReadLine());
            } while (age < 0);
            Console.WriteLine("insanin name daxil edin");
            pr1.Name = Console.ReadLine();
            Console.WriteLine("insanin surname daxil edin");
            pr1.Surname = Console.ReadLine();
            Teacher tr1 = new Teacher();
            int age1;
            do
            {
                Console.WriteLine("teaAHERIN yasi daxil edin:");
                age1 = Convert.ToInt32(Console.ReadLine());
            } while (age1 < 0);
            Console.WriteLine("teaAHERIN name daxil edin");
            tr1.Name = Console.ReadLine();
            Console.WriteLine("teaAHERIN surname daxil edin");
            tr1.Surname = Console.ReadLine();
            int Experience;
            do
            {
                Console.WriteLine("teaAHERIN Experience daxil edin:");
                Experience = Convert.ToInt32(Console.ReadLine());
            } while (Experience <= 0||Experience>80);
       
        }
    }
}
