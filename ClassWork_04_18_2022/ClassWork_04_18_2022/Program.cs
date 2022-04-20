using Microsoft.EntityFrameworkCore;
using System;
using ClassWork_04_18_2022.Models;
using ClassWork_04_18_2022.DAL;
namespace ClassWork_04_18_2022
{
    internal class Program : DbContext
    {
        static void Main(string[] args)
        {
            


        }
        static void AddGroup()
        {

            Course course = new Course()
            {
                Name = "Name1",
                Description = "andsnadnadandja",
                Price = 100
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                dbContext.
            }
        }
    }
}
