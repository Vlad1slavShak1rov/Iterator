using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Library : IEnumerable
    {
        private List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get { return books[index]; }
            set { books.Insert(index, value); }
        }
        public int Count
        { get { return books.Count; } }

       public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
