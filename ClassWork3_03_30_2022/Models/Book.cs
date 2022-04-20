using System;
using System.Collections.Generic;
using System.Text;
using ClassWork3_03_30_2022.Interfaces;

namespace ClassWork3_03_30_2022.Models
{
    internal class Book: IEntity
    {
        private static int _id { get; set; }
        public int Id { get;  }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }
        public Book(string name, string authorName, int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;    
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
