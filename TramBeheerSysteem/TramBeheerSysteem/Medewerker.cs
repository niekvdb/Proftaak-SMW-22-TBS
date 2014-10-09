using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Medewerker
    {
        public int Id { get; private set; }
        public Functie Functie { get; private set; }
        public string Naam { get; private set; }

        public Medewerker(int id, Functie functie, string naam)
        {
            Id = id;
            Functie = functie; 
            Naam = naam;
        }
    }
}
