using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public class TramIndeling
    {
        private List<Spoor> alleSporen = RemiseManager.Sporen;
        private int spoorTeller = 0;
        private bool sporenOp = false;

        public List<Sector> DeelTramIn(Tram tram)
        {
            
            List<Sector> ingedeeldeSectors = null;
            bool sectorFound = false;
            if (sporenOp) return null;
            while (!sectorFound)
            {
                Spoor ingedeeldSpoor = krijgEerstVolgendeSpoor();
                if (ingedeeldSpoor != null)
                {
                    if (1 == 1) //isSpoorBeschikbaar(ingedeeldSpoor))
                    {
                        if (isSpoorLangGenoeg(ingedeeldSpoor, tram.lengte))
                        {
                            ingedeeldeSectors = vrijeSectoren(ingedeeldSpoor, tram);
                            if (ingedeeldeSectors != null)
                            {
                                sectorFound = true;
                            }
                        
                        }
                    }
                }
            }
            return ingedeeldeSectors;
        }

        private Spoor krijgEerstVolgendeSpoor()
        {
            Spoor[] sporenArray = alleSporen.ToArray();
            spoorTeller++;
            if (spoorTeller < sporenArray.Count())
            {
                return sporenArray[spoorTeller];
            }
            else
            {
                sporenOp = true;
                return null;
            }
        }

        private bool isSpoorBeschikbaar(Spoor spoor)
        {
            return (spoor.Beschikbaar);
        }

        private bool isSpoorLangGenoeg(Spoor spoor,int lengte)
        {

            Console.WriteLine("lengte: " + lengte + " SpoorLengte: " + spoor.Lengte);
            return (lengte <= spoor.SectorList.Count);
        }

        private List<Sector> vrijeSectoren(Spoor spoor, Tram tram)
        {
            List<Sector> spoorSectors = RemiseManager.sectorenVanSpoor(spoor.Id);
            List<Sector> sectors = new List<Sector>();
            foreach (Sector s in spoorSectors)
            {
                if (sectors.Count <= tram.lengte)
                {
                    if (s.Beschikbaar && !s.Blokkade)
                    {
                        sectors.Add(s);
                    }
                    else
                    {
                        sectors.Clear();
                    }
                }
            }
            
            return sectors;
        }
    }
}
