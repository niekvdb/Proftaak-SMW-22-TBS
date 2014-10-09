using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Tramonderhoud
    {
        public int Id { get; private set; }
        public Medewerker Medewerker { get; private set; }
        public Tram Tram { get; private set; }
        public DateTime BeschikbaarDatum { get; private set; }
        public string TypeOnderhoud { get; private set; }

        public Tramonderhoud(int id, Medewerker medewerker, Tram tram, DateTime beschikbaarDatum, string typeOnderhoud)
        {
            Id = id;
            Medewerker = medewerker;
            Tram = tram;
            BeschikbaarDatum = beschikbaarDatum;
            TypeOnderhoud = typeOnderhoud;
        }
    }
}
