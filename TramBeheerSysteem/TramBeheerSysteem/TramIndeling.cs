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
        private bool increaseTeller = false;

        /// <summary>
        /// Functie met algoritme waarmee de tram ingedeeld wordt op een spoor(/op sectoren)
        /// </summary>
        /// <param name="tram">tram die ingedeeld moet worden</param>
        /// <returns>Lijst met sectoren waarop de tram is ingedeeld</returns>
        public List<Sector> DeelTramIn(Tram tram)
        {
           /* if (tram.nummer == 834)
            {
                //breakpoint
            } */
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
                        else
                        {
                            spoorTeller++;
                            increaseTeller = true;
                        }
                    }
                }
            }
            if (increaseTeller) spoorTeller = 0;
            return ingedeeldeSectors;
        }
        /// <summary>
        /// Functie om het (eerst)volgende spoor te krijgen.
        /// </summary>
        /// <returns>(eerst)volgende spoor</returns>
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
                if (s.Tram == null&&!s.Blokkade)
                {
                    sectorsleft = true;
                }
            }
            if (!sectorsleft)// && !increaseTeller)
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
        /// <summary>
        /// Controleert of het spoor beschikbaar is
        /// </summary>
        /// <param name="spoor">spoor dat gecontroleerd moet worden</param>
        /// <returns>true als het spoor beschikbaar is</returns>
        private bool isSpoorBeschikbaar(Spoor spoor)
        {
            return (spoor.Beschikbaar);
        }
        /// <summary>
        /// Kijkt of het spoor lang genoeg is voor de tram
        /// </summary>
        /// <param name="spoor">spoor dat gecontroleerd moet worden</param>
        /// <param name="lengte">lengte van de tram</param>
        /// <returns>true als het spoor lang genoeg is</returns>
        private bool isSpoorLangGenoeg(Spoor spoor,int lengte)
        {

            Console.WriteLine("lengte: " + lengte + " SpoorLengte: " + spoor.SectorList.Count());
            return (lengte <= spoor.SectorList.Count);
        }
        /// <summary>
        /// Zoekt vrije sectors waar de tram (qua lengte) op kan staan
        /// </summary>
        /// <param name="spoor">spoor waarin sectoren gezocht moeten worden</param>
        /// <param name="tram">tram die geplaatst moet worden</param>
        /// <returns></returns>
        private List<Sector> vrijeSectoren(Spoor spoor, Tram tram)
        {
            List<Sector> spoorSectors = RemiseManager.sectorenVanSpoor(spoor.Id);
            List<Sector> sectors = new List<Sector>();
            spoorSectors.Reverse(); // Reverse list, zodat de tram eerst op de achterste sectoren v/h spoor komt te staan
            foreach (Sector s in spoorSectors)
            {
                if (s.Blokkade)
                {
                    sectors.Clear();
                    /*if (!blockedSector)
                    {
                            spoorTeller++;
                            blockedSector = true;
                            increaseTeller = true;
                    }*/
                }
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
        /// <summary>
        /// Functie om een tram toe te voegen aan sectoren.
        /// </summary>
        /// <param name="sectorlist">lijst met sectoren waarop de tram komt te staan</param>
        /// <param name="tram">tram die aan de sectoren wordt toegevoegd</param>
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
