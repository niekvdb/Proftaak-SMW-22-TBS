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

        public List<Sector> DeelTramIn(Tram tram)
        {
            Spoor ingedeeldSpoor = krijgEerstVolgendeSpoor();
            if (krijgEerstVolgendeSpoor() != null)
            {
                if (isSpoorBeschikbaar(ingedeeldSpoor))
                {
                    if (isSpoorLangGenoeg(ingedeeldSpoor, tram.lengte))
                    {
                        List<Sector> ingedeeldeSectors = vrijeSectoren(ingedeeldSpoor, tram);
                        if (ingedeeldeSectors != null)
                        {
                            return ingedeeldeSectors;
                        }
                    }
                }
            }
            return null;
        }

        private Spoor krijgEerstVolgendeSpoor()
        {
            Spoor[] sporenArray = alleSporen.ToArray();
            spoorTeller++;
            if (sporenArray.Count() <= spoorTeller)
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
            return (spoor.Lengte <= lengte);
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
            
            return null;
        }
    }
}
