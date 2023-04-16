using System;
using System.Collections;

namespace SRP
{
    public class Estante
    {
        ArrayList ListaLibros = new ArrayList();
        public string LibraryShelve { get ; set; }
        
        public Estante(String shelve)
        {
            this.LibraryShelve = shelve; 

        }

        public void AddBook(Book book)
        {
            ListaLibros.Add(book);
            Console.WriteLine($"Se agrego el libro {book} al estante {this.LibraryShelve}");
        }

        public override string ToString()
        {
            return $"{this.LibraryShelve}";
        }
        
    }
}
