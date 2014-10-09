using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Spoor
    {
        public int Id { get; private set; }
        public Remise Remise { get; private set; }
        public int Nummer { get; private set; }
        public int Lengte { get; private set; }
        public bool Beschikbaar { get; private set; }
        public bool InUitRijSpoor { get; private set; }
        public bool Blokkade { get; private set; }

        public Spoor(int id, Remise remise, int nummer, int lengte, bool beschikbaar, bool blokkade, bool inUitRijSpoor)
        {
            this.Id = id;
            this.Remise = remise;
            this.Nummer = nummer;
            this.Lengte = lengte;
            this.Beschikbaar = beschikbaar;
            this.Blokkade = blokkade;
            this.InUitRijSpoor = inUitRijSpoor;
        }

        public void blokkeer()
        {
            //ToDo
        }
    }
}
