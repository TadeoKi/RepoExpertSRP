using System;
using System.Collections;

namespace SRP
{
    public class Sector
    {
        
        ArrayList ListaEstantes = new ArrayList();
        public string LibrarySector { get ; set; }

        public Sector(String sector)
        {
            this.LibrarySector = sector;
        }

        public void AddShelve(Estante estante)
        {
            ListaEstantes.Add(estante);
            Console.WriteLine($"Se agrego el Estante {estante} al sector {this.LibrarySector}");
        }

        public override string ToString()
        {
            return $"{this.LibrarySector}";
        }

    }
}
