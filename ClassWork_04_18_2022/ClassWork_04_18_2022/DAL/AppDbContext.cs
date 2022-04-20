using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_04_18_2022.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = @"Server=LAPTOP-8O8EM6DT;Database=CourseDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
