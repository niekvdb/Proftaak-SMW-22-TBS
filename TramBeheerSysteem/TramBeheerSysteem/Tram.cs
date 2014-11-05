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
        public Tramtype tramtype { get; private set; }
        public int lengte { get; private set; }
        public string status { get; private set; }
        public Remise remise { get; private set; }
        public bool vervuild { get; private set; }
        public bool defect { get; private set; }
        public bool conducteurGeschikt { get; private set; }
        public bool beschikbaar { get; private set; }

        public Tram(int id, Tramtype tramtype, int lengte, string status, Remise remise, bool vervuild, bool defect, bool conducteurGeschikt, bool beschikbaar)
        {
            this.id = id;
            this.tramtype = tramtype;
            this.lengte = lengte;
            this.status = status;
            this.remise = remise;
            this.vervuild = vervuild;
            this.defect = defect;
            this.conducteurGeschikt = conducteurGeschikt;
            this.beschikbaar = beschikbaar;
        }

        public void Onderhoud(TypeOnderhoud typeOnderhoud, string opmerking)
        {
            this.IsNietVervuild();
            Tramonderhoud onderhoud = new Tramonderhoud(null, this, DateTime.Now, typeOnderhoud, opmerking);
            DatabaseManager.registreerOnderhoud(onderhoud);
        }

        public void IsVervuild()
        {
            this.vervuild = true;
        }

        public void IsDefect()
        {
            this.defect = true;
        }

        public void IsNietVervuild()
        {
            this.vervuild = false;
        }

        public void IsNietDefect()
        {
            this.defect = false;
        }
    }
}
