using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Study
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by step", Price = 5 },
                new Book() { Title = "ASP.NET MVC", Price = 9.99f },
                new Book() { Title = "ASP.NET Web API", Price = 12 },
                new Book() { Title = "C# Advanced Topics", Price = 7 },
                new Book() { Title = "C# Beginner Topics", Price = 9 }
            };
        }
    }
}
