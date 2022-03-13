using System;
using System.Collections.Generic;
using System.Text;

namespace EXCEPTION_task1.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public GenreType GenreType { get; set; }
        public Book(string name, string author, int pageCount, GenreType genreType)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            GenreType = genreType;
        }

        public override string ToString()
        {
            return $"Adi- {Name}\nYazici- {Author}\nSehife sayi- {PageCount}\nJanr novu- {GenreType}\n";
        }

    }

}



