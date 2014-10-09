using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class Tram
    {
        public int Id { get; private set; }
        public Remise remise { get; private set; }
        public Tramtype tramtype { get; private set; }
        public int nummer { get; private set; }
        public int lengte { get; private set; }
        public string status { get; private set; }
        public bool vervuild { get; private set; }
        public bool defect { get; private set; }
        public bool conducteurGeschikt { get; private set; }
        public bool beschikbaar { get; private set; }
        public Sector sector { get; private set; }

        public Tram(int id, Remise remise, Tramtype tramtype, int nummer, int lengte, string status, bool vervuild, bool defect, bool conducteurGeschikt, Sector sector, bool beschikbaar)
        {
            this.Id = id;
            this.remise = remise;
            this.tramtype = tramtype;
            this.nummer = nummer;
            this.lengte = lengte;
            this.status = status;
            this.vervuild = vervuild;
            this.defect = defect;
            this.conducteurGeschikt = conducteurGeschikt;
            this.sector = sector;
            this.beschikbaar = beschikbaar;
        }
    }
}
