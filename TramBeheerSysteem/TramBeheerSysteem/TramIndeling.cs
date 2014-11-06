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
        private bool sporenOp = false;
        int spoorTeller = 0;

        public List<Sector> DeelTramIn(Tram tram)
        {
            
            List<Sector> ingedeeldeSectors = null;
            bool sectorFound = false;
            while (!sectorFound)
            {
                if (sporenOp) return null; // anders ingedeeldesectors = null en sectorFound = true;
                Spoor ingedeeldSpoor = krijgEerstVolgendeSpoor();
                if (ingedeeldSpoor != null)
                {
                    if (isSpoorBeschikbaar(ingedeeldSpoor))
                    {
                        if (isSpoorLangGenoeg(ingedeeldSpoor, tram.lengte))
                        {
                            ingedeeldeSectors = vrijeSectoren(ingedeeldSpoor, tram);
                            if (ingedeeldeSectors.Count() < tram.lengte)
                            {
                                ingedeeldeSectors = null;
                            }
                            if (ingedeeldeSectors != null && ingedeeldeSectors.Any())
                            {
                                sectorFound = true;
                                voegTramAanSectorsToe(ingedeeldeSectors,tram);
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
            bool sectorsleft = false;
            if (spoorTeller >= sporenArray.Count())
            {
                Console.WriteLine("Sporen vol");
                sporenOp = true;
                return null;
            }

                foreach (Sector s in sporenArray[spoorTeller].SectorList)
            {
                if (s.Tram == null)
                {
                    sectorsleft = true;
                }
            }
            if (!sectorsleft)
            {
                spoorTeller++;
            }
            if (spoorTeller < sporenArray.Count())
            {
                return sporenArray[spoorTeller];
            }
            else
            {
                return null;
            }
        }

        private bool isSpoorBeschikbaar(Spoor spoor)
        {
            return (spoor.Beschikbaar);
        }

        private bool isSpoorLangGenoeg(Spoor spoor,int lengte)
        {

            Console.WriteLine("lengte: " + lengte + " SpoorLengte: " + spoor.SectorList.Count());
            return (lengte <= spoor.SectorList.Count);
        }

        private List<Sector> vrijeSectoren(Spoor spoor, Tram tram)
        {
            List<Sector> spoorSectors = RemiseManager.sectorenVanSpoor(spoor.Id);
            List<Sector> sectors = new List<Sector>();
            spoorSectors.Reverse(); // Reverse list, zodat de tram eerst op de achterste sectoren v/h spoor komt te staan
            foreach (Sector s in spoorSectors)
            {
                if (sectors.Count < tram.lengte)
                {
                    if (s.Beschikbaar && !s.Blokkade && s.Tram == null)
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

        private void voegTramAanSectorsToe(List<Sector> sectorlist, Tram tram)
        {
            foreach (Sector s in RemiseManager.Sectors)
            {
                foreach (Sector se in sectorlist)
                {
                    if (s.Id == se.Id)
                    {
                        s.VoegTramToe(tram);
                    }
                }
            }
        }
    }
}
