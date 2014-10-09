using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Spoor
    {
        public int ID { get; private set; }
        public Remise remise { get; private set; }
        public int nummer { get; private set; }
        public int lengte { get; private set; }
        public bool beschikbaar { get; private set; }
        public bool inUitRijSpoor { get; private set; }
        public bool blokkade { get; private set; }

        public Spoor (int mID, Remise mremise, int mnummer, int mlengte, bool mbeschikbaar, bool minUitRijSpoor, bool mblokkade)
        {
            this.ID = mID;
            this.remise = mremise;
            this.nummer = mnummer;
            this.lengte = mlengte;
            this.beschikbaar = mbeschikbaar;
            this.inUitRijSpoor = minUitRijSpoor;
            this.blokkade = mblokkade;
        }

        public void blokkeer()
        {
            //ToDo
        }
    }
}
