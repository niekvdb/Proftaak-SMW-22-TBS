using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public class Tram
    {
        public int id { get; private set; }
        public Remise remise { get; private set; }
        public Tramtype tramtype { get; private set; }
        public int nummer { get; private set; }
        public int lengte { get; private set; }
        public string status { get; private set; }
        public bool vervuild { get; private set; }
        public bool defect { get; private set; }
        public bool conducteurGeschikt { get; private set; }
        public Sector sector { get; private set; }
        public bool beschikbaar { get; private set; }

        public Tram(int id, Remise remise, Tramtype tramtype, int lengte, string status, bool vervuild, bool defect, bool conducteurGeschikt, bool beschikbaar, Sector sector)
        {
            this.id = id;
            this.remise = remise;
            this.tramtype = tramtype;
            this.lengte = lengte;
            this.status = status;
            this.vervuild = vervuild;
            this.defect = defect;
            this.conducteurGeschikt = conducteurGeschikt;
            this.beschikbaar = beschikbaar;
            this.sector = sector;
        }

        public void Verplaats(Sector newSector)
        {
            Sector oldSector = this.sector;
            oldSector.ClearSector();
            this.sector = newSector;
        }

        public void Onderhoud(TypeOnderhoud typeOnderhoud)
        {
            //ToDo
        }

        public void IsVervuild()
        {
            //ToDO
        }

        public void IsDefect()
        {
            //ToDo
        }
    }
}
