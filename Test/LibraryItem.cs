using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class LibraryItem
    {
        protected internal string? Title;
        public string? GetTitle() { return Title; }


    }
    public class Book : LibraryItem
    {
        public Book(string bookTitle)
        {
            Title = bookTitle;
        }
    }
}
