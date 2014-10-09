using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Sector
    {
        public int ID { get; private set; }
        public Spoor spoor { get; private set; }
        public Tram tram { get; private set; }
        public int nummer { get; private set; }
        public bool beschikbaar { get; private set; }
        public bool blokkade { get; private set; }

        public Sector (int mID, Spoor mspoor, Tram mtram, int mnummer, bool mbeschikbaar, bool mblokkade)
        {
            this.ID = mID;
            this.spoor = mspoor;
            this.tram = mtram;
            this.nummer = mnummer;
            this.beschikbaar = mbeschikbaar;
            this.blokkade = mblokkade;
        }

        public void blokkeer()
        {
            //ToDo
        }
    }
}
