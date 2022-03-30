using System;
using System.Threading;

namespace ClassWork_03_30_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime
            //DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
            //int yearyear = myDate.Year; // 2015  
            //int month = myDate.Month; //12  
            //int day = myDate.Day; // 25  
            //int hour = myDate.Hour; // 10  
            //int minute = myDate.Minute; // 30  
            //int second = myDate.Second; // 45  
            //int weekDay = (int)myDate.DayOfWeek; // 5 due to Friday  

            ////Console.WriteLine(month);
            //DateTime date = new DateTime();

            //// Adding days to a date  
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today);

            //// Parsing  
            //string dateString = "Wed Dec 30, 2015";
            //DateTime dateTime12 = DateTime.Parse(dateString); // 12/30/2015 12:00:00 AM 

            //DateTime dt = new DateTime(2022, 03, 30);
            //bool isEqual = dt.DayOfWeek == (DayOfWeek.Wednesday);
            //Console.WriteLine(isEqual);



            //DateTime saveNow = DateTime.Now;
            //DateTime saveUtcNow = DateTime.UtcNow;

            //DateTime myDate1 = DateTime.SpecifyKind(saveUtcNow, DateTimeKind.Utc); // 3/30/2022 4:47:31 AM    
            //DateTime myDate2 = DateTime.SpecifyKind(saveNow, DateTimeKind.Local); // 3/30/2022 8:47:31 AM    

            //Console.WriteLine("Kind: " + myDate1.Kind); // Utc  
            //Console.WriteLine("Kind: " + myDate2.Kind); // Local  

            //Console.WriteLine("Utc Time: " + myDate1); // 3/30/2022 4:47:31 AM  
            //Console.WriteLine("Local Time: " + myDate2); // 3/30/2022 8:47:31 AM  




            //DateTime tempDate = new DateTime(2022, 03, 30); // creating date object with 8th December 2015  
            //Console.WriteLine(tempDate.ToString("dddd / MMMM / yy")); //Wednesday / March / 22
            //Console.WriteLine(tempDate.ToString("MMMM dd")); // March 30

            //DateTime todayData = DateTime.Now;
            //Console.WriteLine(todayData.ToString("MMMM dd")); // March 30

            //Person person = new Person("aaaaaaaa");
            //Thread.Sleep(2000);
            //Person person1 = new Person("bbbbbb");
            #endregion

            Console.WriteLine($"Max: {Math.Max(5, 10)}");
            Console.WriteLine($"Min: {Math.Min(5, 10)}");
            Console.WriteLine($"Kok: {Math.Sqrt(64)}");
            Console.WriteLine($"Square: {Math.Sqrt(64)}");
            Console.WriteLine($"Absolute: {Math.Abs(-4.7)}");
            Console.WriteLine($"Nearest whole number: {Math.Round(9.99)}");
            Console.WriteLine($"Return the smallest integral value: {Math.Floor(9.99)}");
            Console.WriteLine($"Return the biggest integral value: {Math.Ceiling(9.99)}");

        }
    }
    #region DateTime
    //class Person
    //{
    //    public string Name { get; set; }

    //    public DateTime time { get; set; } = DateTime.Now;
        
    //    public Person(string name)
    //    {
    //        Name = name;
    //        Console.WriteLine(time.ToString("MMMM dd FFF"));
    //    }
    //}
    #endregion


}
