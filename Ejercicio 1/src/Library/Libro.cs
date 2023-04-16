using System;

namespace SRP
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

        public override string ToString()
        {
            return $"{this.Title} de {this.Author},codigo {this.Code}";
        }
    }
}
