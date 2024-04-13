using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get ; } 
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)

        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}