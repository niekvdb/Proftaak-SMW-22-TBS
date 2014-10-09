using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Remise
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public int GroteServicebeurtenPerDag { get; private set; }
        public int KleineServicebeurtenPerDag { get; private set; }
        public int GroteSchoonmaakbeurtenPerDag { get; private set; }
        public int KleineSchoonmaakbeurtenPerDag { get; private set; }

        public Remise(string naam, int id, int groteServicebeurtenPerDag, int kleineServicebeurtenPerDag, int kleineSchoonmaakbeurtenPerDag, int groteSchoonmaakbeurtenPerDag)
        {
            Naam = naam;
            Id = id;
            GroteServicebeurtenPerDag = groteServicebeurtenPerDag;
            KleineServicebeurtenPerDag = kleineServicebeurtenPerDag;
            KleineSchoonmaakbeurtenPerDag = kleineSchoonmaakbeurtenPerDag;
            GroteSchoonmaakbeurtenPerDag = groteSchoonmaakbeurtenPerDag;
        }
    }
}
