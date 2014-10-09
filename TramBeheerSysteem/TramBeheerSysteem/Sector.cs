using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Sector
    {
        public int Id { get; private set; }
        public Spoor Spoor { get; private set; }
        public Tram Tram { get; private set; }
        public int Nummer { get; private set; }
        public bool Beschikbaar { get; private set; }
        public bool Blokkade { get; private set; }

        public Sector(Spoor spoor, int id, int nummer, Tram tram, bool beschikbaar, bool blokkade)
        {
            this.Spoor = spoor;
            this.Id = id;
            this.Nummer = nummer;
            this.Tram = tram;
            this.Beschikbaar = beschikbaar;
            this.Blokkade = blokkade;
        }

        public void blokkeer()
        {
            //ToDo
        }
    }
}
