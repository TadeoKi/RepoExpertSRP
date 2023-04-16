using System;

namespace SRP
{

    public class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

            Estante Siete = new Estante("7");
            Siete.AddBook(book1);
            
            
            Sector A = new Sector("A");
            A.AddShelve(Siete);

             
        }

        
    }
}