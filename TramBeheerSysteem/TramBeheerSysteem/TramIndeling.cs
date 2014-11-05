using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    class TramIndeling
    {
        List<Spoor> alleSporen = null;//dbManager.AlleSporen();
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
                        else
                        {
                            DeelTramIn(tram);
                        }
                    }
                    else
                    {
                        DeelTramIn(tram);
                    }
                }
                else
                {
                    DeelTramIn(tram);
                }
            }
            else
            {
                return null;
            }
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
        }
    }
}
