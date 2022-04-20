using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age1;
            Console.WriteLine("age daxil edin");
            age1 = Convert.ToInt32(Console.ReadLine());
            while (age1<0)
            {
                Console.WriteLine("age yeniden dail edin, menfi ola bilmez");
                age1 = Convert.ToInt32(Console.ReadLine());

            }
            int poin1;
            Console.WriteLine("point daxil edin");
            poin1 = Convert.ToInt32(Console.ReadLine());
            while (poin1 < 0)
            {
                Console.WriteLine("point yeniden dail edin, menfi ola bilmez");
                poin1 = Convert.ToInt32(Console.ReadLine());
               while(poin1 <= 0)
                {
                    while (poin1 >= 100)
                    {
                        Console.WriteLine("point YUZLE SIFIR DAAXILINDE OLMALIDIR");
                        poin1 = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Student student1 = new Student("ali", "azadov", poin1, 5, age1);
            Console.WriteLine( " age :"+age1);
            Console.WriteLine(" point :" +poin1  );
            student1.ShowInfo();
           
         
        }
    }
}
