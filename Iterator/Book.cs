using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }

        public Book(string title, string author, int date)
        {
            Title = title;
            Author = author;
            Year = date;
        }
    }
}
